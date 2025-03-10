using System.Text.Json;
using System;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler
{
    public abstract class Endpoint
    {
        private readonly EndpointOptions _opts;

        protected Endpoint(EndpointOptions opts)
        {
            _opts = opts;
        }

        protected async Task<Result> ExecuteAsync<TRequest>(string endpoint, Method method, TRequest requestParameters)
        {
            try
            {
                (string uri, string key) = _opts;

                Uri baseUri = new(uri);
                Uri endpointUri = new(baseUri, endpoint);

                RestClient client = new(uri);
                RestRequest request = new(endpointUri, method);
                request.AddHeader("accept-encoding", "gzip, deflate");
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("X-API-KEY", key);
                request.AddBody(requestParameters);

                RestResponse<ImportResult> response = await client.ExecuteAsync<ImportResult>(request);
                return response.IsSuccessful && response.Data?.StatusCode == 200 ? Result.Ok(response.StatusDescription) : Result.Fail(GetError(response));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

        private static string GetError(RestResponse response)
        {
            try
            {
                if (string.IsNullOrEmpty(response.Content))
                    return $"Received an empty response from {response.Request?.Resource ?? "N/A"}: {response.ErrorMessage ?? "N/A"}";

                FailedRequest failedRequest = JsonSerializer.Deserialize<FailedRequest>(response.Content);
                FailedRequestException ex = JsonSerializer.Deserialize<FailedRequestException>(failedRequest.Content);
                return ex.Description;
            }
            catch (Exception ex)
            {
                return $"An unhandled exception occurred when reading the response: {ex.Message}.";
            }
        }
    }
}