using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class DimeSchedulerRestClient<TRequest> : IDimeSchedulerRestClient<TRequest>
    {
        private readonly AuthenticationOptions _opts;

        public DimeSchedulerRestClient(AuthenticationOptions opts)
        {
            _opts = opts;
        }

        public void Execute(string endpoint, Method method, TRequest requestParameters)
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

            RestResponse response = client.Execute(request);
            if (response.IsSuccessful)
                return;

            WebApiException exception = JsonSerializer.Deserialize<WebApiException>(response.Content);
            throw new WebException(exception.Description);
        }

        public async Task ExecuteAsync(string endpoint, Method method, TRequest requestParameters)
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

            RestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
                return;

            WebApiException exception = JsonSerializer.Deserialize<WebApiException>(response.Content);
            throw new WebException(exception.Description);
        }

        public T Execute<T>(string endpoint, Method method, TRequest requestParameters)
        {
            Uri baseUri = new(_opts.Uri);
            Uri endpointUri = new(baseUri, endpoint);

            RestClient client = new(endpointUri);
            RestRequest request = new(endpointUri, method);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("X-API-KEY", _opts.Key);

            if (method != Method.Get)
                request.AddBody(requestParameters, ContentType.Json);
            else
                foreach (PropertyInfo prop in requestParameters.GetType().GetProperties())
                    request.AddParameter(prop.Name, prop.GetValue(requestParameters, null)?.ToString() ?? "");

            RestResponse<T> response = client.Execute<T>(request);

            if (response.IsSuccessful)
                return response.Data;

            throw response.ContentType switch
            {
                "text/plain" => SerializePlainTextError(response),
                string ct when ct.Contains("application/json") => SerializeJsonError(response),
                _ => SerializePlainTextError(response),
            };
        }

        public async Task<T> ExecuteAsync<T>(string endpoint, Method method, TRequest requestParameters)
        {
            Uri baseUri = new(_opts.Uri);
            Uri endpointUri = new(baseUri, endpoint);

            RestClient client = new(endpointUri);
            RestRequest request = new(endpointUri, method);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("X-API-KEY", _opts.Key);

            if (method != Method.Get)
                request.AddBody(requestParameters, ContentType.Json);
            else
                foreach (PropertyInfo prop in requestParameters.GetType().GetProperties())
                    request.AddParameter(prop.Name, prop.GetValue(requestParameters, null)?.ToString() ?? "");

            RestResponse<T> response = await client.ExecuteAsync<T>(request);

            if (response.IsSuccessful)
                return response.Data;

            throw response.ContentType switch
            {
                "text/plain" => SerializePlainTextError(response),
                string ct when ct.Contains("application/json") => SerializeJsonError(response),
                _ => SerializePlainTextError(response),
            };
        }

        public T Execute<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters)
        {
            Uri baseUri = new(_opts.Uri);
            Uri endpointUri = new(baseUri, endpoint);

            RestClient client = new(endpointUri);
            RestRequest request = new(endpointUri, method);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("X-API-KEY", _opts.Key);

            if (method != Method.Get)
                request.AddJsonBody(requestParameters);
            else
                foreach (PropertyInfo prop in requestParameters.GetType().GetProperties())
                    request.AddParameter(prop.Name, prop.GetValue(requestParameters, null)?.ToString() ?? "");

            RestResponse<T> response = client.Execute<T>(request);

            if (response.IsSuccessful)
                return response.Data;

            throw response.ContentType switch
            {
                "text/plain" => SerializePlainTextError(response),
                "application/json" => SerializeJsonError(response),
                _ => SerializePlainTextError(response),
            };
        }

        public async Task<T> ExecuteAsync<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters)
        {
            Uri baseUri = new(_opts.Uri);
            Uri endpointUri = new(baseUri, endpoint);

            RestClient client = new(endpointUri);
            RestRequest request = new(endpointUri, method);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("X-API-KEY", _opts.Key);

            if (method != Method.Get)
                request.AddJsonBody(requestParameters);
            else
                foreach (PropertyInfo prop in requestParameters.GetType().GetProperties())
                    request.AddParameter(prop.Name, prop.GetValue(requestParameters, null)?.ToString() ?? "");

            RestResponse<T> response = await client.ExecuteAsync<T>(request);

            if (response.IsSuccessful)
                return response.Data;

            throw response.ContentType switch
            {
                "text/plain" => SerializePlainTextError(response),
                "application/json" => SerializeJsonError(response),
                _ => SerializePlainTextError(response),
            };
        }

        private static WebApiException SerializePlainTextError<T>(RestResponse<T> response)
            => new()
            {
                Description = response.Content ?? response.StatusDescription,
                StatusCode = response.StatusCode
            };

        private static WebApiException SerializeJsonError<T>(RestResponse<T> response)
        {
            WebApiException exception = JsonSerializer.Deserialize<WebApiException>(response.Content);
            exception.StatusCode = response.StatusCode;
            return exception;
        }
    }
}