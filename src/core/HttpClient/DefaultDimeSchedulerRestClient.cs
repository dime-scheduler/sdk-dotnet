using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    [ExcludeFromCodeCoverage]
    public class DefaultDimeSchedulerRestClient<TRequest> : IDimeSchedulerRestClient<TRequest>
    {
        private readonly AuthenticationOptions _opts;

        public DefaultDimeSchedulerRestClient(AuthenticationOptions opts)
        {
            _opts = opts;
        }

        public async Task Execute(string endpoint, Method method, TRequest requestParameters)
        {
            (string uri, string key) = _opts;

            Uri baseUri = new(uri);
            Uri endpointUri = new(baseUri, endpoint);

            RestClient client = new(endpointUri);
            RestRequest request = new(method);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("X-API-KEY", key);
            request.AddJsonBody(requestParameters);

            IRestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
                return;

            WebApiException exception = JsonSerializer.Deserialize<WebApiException>(response.Content);
            throw new WebException(exception.Description);
        }

        public async Task<T> Execute<T>(string endpoint, Method method, TRequest requestParameters)
        {
            Uri baseUri = new(_opts.Uri);
            Uri endpointUri = new(baseUri, endpoint);

            RestClient client = new(endpointUri);
            RestRequest request = new(method);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("X-API-KEY", _opts.Key);

            if (method != Method.GET)
                request.AddJsonBody(requestParameters);
            else
                foreach (PropertyInfo prop in requestParameters.GetType().GetProperties())
                    request.AddParameter(prop.Name, prop.GetValue(requestParameters, null)?.ToString() ?? "");

            IRestResponse<T> response = await client.ExecuteAsync<T>(request);

            if (response.IsSuccessful)
                return response.Data;

            throw response.ContentType switch
            {
                "text/plain" => SerializePlainTextError(response),
                string ct when ct.Contains("application/json") => SerializeJsonError(response),
                _ => throw new NotImplementedException(),
            };
        }

        public async Task<T> Execute<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters)
        {
            Uri baseUri = new(_opts.Uri);
            Uri endpointUri = new(baseUri, endpoint);

            RestClient client = new(endpointUri);
            RestRequest request = new(method);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("X-API-KEY", _opts.Key);

            if (method != Method.GET)
                request.AddJsonBody(requestParameters);
            else
                foreach (PropertyInfo prop in requestParameters.GetType().GetProperties())
                    request.AddParameter(prop.Name, prop.GetValue(requestParameters, null)?.ToString() ?? "");

            IRestResponse<T> response = await client.ExecuteAsync<T>(request);

            if (response.IsSuccessful)
                return response.Data;

            throw response.ContentType switch
            {
                "text/plain" => SerializePlainTextError(response),
                "application/json" => SerializeJsonError(response),
                _ => SerializePlainTextError(response),
            };
        }

        private static WebApiException SerializePlainTextError<T>(IRestResponse<T> response)
            => new()
            {
                Description = response.Content ?? response.StatusDescription,
                StatusCode = response.StatusCode
            };

        private static WebApiException SerializeJsonError<T>(IRestResponse<T> response)
        {
            WebApiException exception = JsonSerializer.Deserialize<WebApiException>(response.Content);
            exception.StatusCode = response.StatusCode;
            return exception;
        }
    }
}