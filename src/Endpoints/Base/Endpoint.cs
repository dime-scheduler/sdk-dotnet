using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Serializers.Json;

namespace Dime.Scheduler
{
    internal abstract class Endpoint
    {
        protected readonly EndpointOptions _opts;

        protected Endpoint(EndpointOptions opts)
        {
            _opts = opts;
        }

        protected virtual async Task<Result> ExecuteAsync<TRequest>(string endpoint, Method method, TRequest requestParameters, bool expectsArray = false)
        {
            try
            {
                (string uri, string key) = _opts;

                Uri baseUri = new(uri);
                Uri endpointUri = new(baseUri, endpoint);

                JsonSerializerOptions options = new()
                {
                    PropertyNameCaseInsensitive = true
                };

                RestClient client = new(uri, configureSerialization: s => s.UseSystemTextJson(options));
                RestRequest request = new(endpointUri, method);
                request.AddHeader("accept-encoding", "gzip, deflate");
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("X-API-KEY", key);
                request.AddBody(expectsArray ? new List<TRequest> { requestParameters } : requestParameters);

                RestResponse<ImportResult> response = await client.ExecuteAsync<ImportResult>(request);
                return response.IsSuccessful && (response.Data?.IsSuccess ?? false)
                    ? Result.Ok(response.StatusDescription, response.Data.GetSuccessContent().Appointments)
                    : Result.Fail(GetError(response));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

        protected static string GetError(RestResponse<ImportResult> response)
        {
            try
            {
                if (!response.IsSuccessful)
                {
                    if (string.IsNullOrEmpty(response.StatusDescription))
                        return $"Received an empty response from {response.Request?.Resource ?? "N/A"}: {response.ErrorMessage ?? "N/A"}";

                    return $"{(int)response.StatusCode} {response.StatusDescription}";
                }

                if (!response.Data.IsSuccess)
                    return response.Data.GetFailedContent();

                return $"Unhandled exception occurred.";
            }
            catch (Exception ex)
            {
                return $"An unhandled exception occurred when reading the response: {ex.Message}.";
            }
        }
    }
}