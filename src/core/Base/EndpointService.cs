using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public abstract class EndpointService<TRequest> where TRequest : IRequestParameter
    {
        protected EndpointService()
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="method"></param>
        /// <param name="requestParameters"></param>
        /// <returns></returns>
        protected async Task<IRestResponse> Execute(string endpoint, Method method, TRequest requestParameters)
        {
            Uri baseUri = new Uri(requestParameters.Uri);
            Uri endpointUri = new Uri(baseUri, endpoint);

            RestClient client = new(endpointUri);
            RestRequest request = new(method);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("authorization", "Bearer " + requestParameters.AuthenticationToken);
            request.AddJsonBody(requestParameters);

            IRestResponse response = await client.ExecuteAsync(request);
            if (!response.IsSuccessful)
                throw new WebException(response.ErrorMessage, response.ErrorException);

            return response;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="method"></param>
        /// <param name="requestParameters"></param>
        /// <returns></returns>
        protected async Task<T> Execute<T>(string endpoint, Method method, TRequest requestParameters)
        {
            Uri baseUri = new Uri(requestParameters.Uri);
            Uri endpointUri = new Uri(baseUri, endpoint);

            RestClient client = new(endpointUri);
            RestRequest request = new(method);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("authorization", "Bearer " + requestParameters.AuthenticationToken);

            if (method != Method.GET)
                request.AddJsonBody(requestParameters);
            else
                foreach (PropertyInfo prop in requestParameters.GetType().GetProperties())
                    request.AddParameter(prop.Name, prop.GetValue(requestParameters, null)?.ToString() ?? "");

            IRestResponse<T> response = await client.ExecuteAsync<T>(request);
            if (!response.IsSuccessful)
                throw new WebException(response.ErrorMessage, response.ErrorException);

            return response.Data;
        }
    }
}