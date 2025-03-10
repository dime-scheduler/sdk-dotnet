using System.Text.Json;
using System;
using System.Threading.Tasks;
using RestSharp;
using Dime.Scheduler.Entities;

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
                if (response.IsSuccessful)
                {
                    if (response.Data.StatusCode == 200)
                        return Result.Ok(response.StatusDescription);

                    WebApiException ex = response.ContentType switch
                    {
                        "text/plain" => SerializePlainTextError(response),
                        string ct when ct.Contains("application/json") => SerializeJsonError(response),
                        _ => SerializePlainTextError(response),
                    };

                    return Result.Fail(ex.Message);
                }

                WebApiException exception = JsonSerializer.Deserialize<WebApiException>(response.Content);
                return Result.Fail(exception.Description);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

        private static WebApiException SerializePlainTextError<T>(RestResponse<T> response)
            => new()
            {
                Description = response.Content ?? response.StatusDescription,
                StatusCode = response.StatusCode
            };

        private static WebApiException SerializeJsonError<T>(RestResponse<T> response)
        {
            FailedRequest failedRequest = JsonSerializer.Deserialize<FailedRequest>(response.Content);
            FailedRequestException ex = JsonSerializer.Deserialize<FailedRequestException>(failedRequest.Content);
            return new WebApiException
            {
                Error = failedRequest.Content,
                StatusCode = failedRequest.StatusCode
            };
        }
    }
}