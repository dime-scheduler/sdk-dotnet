using System;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public abstract class Endpoint<TRequest> where TRequest : class
    {
        private readonly AuthenticationOptions _opts;

        protected Endpoint(AuthenticationOptions opts)
        {
            _opts = opts;
        }

        protected async Task<IRestResponse> Execute(string endpoint, Method method, TRequest requestParameters)
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
            request.AddHeader("authorization", "Bearer " + _opts.AuthenticationToken);
            request.AddJsonBody(requestParameters);

            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful ? response : throw new WebException(response.ErrorMessage, response.ErrorException);
        }

        protected async Task<T> Execute<T>(string endpoint, Method method, TRequest requestParameters)
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
            request.AddHeader("authorization", "Bearer " + _opts.AuthenticationToken);

            if (method != Method.GET)
                request.AddJsonBody(requestParameters);
            else
                foreach (PropertyInfo prop in requestParameters.GetType().GetProperties())
                    request.AddParameter(prop.Name, prop.GetValue(requestParameters, null)?.ToString() ?? "");

            IRestResponse<T> response = await client.ExecuteAsync<T>(request);
            return response.IsSuccessful ? response.Data : throw new WebException(response.ErrorMessage, response.ErrorException);
        }
    }
}