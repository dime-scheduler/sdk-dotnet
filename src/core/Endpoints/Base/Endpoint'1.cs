using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler
{
    public abstract class Endpoint<TRequest> where TRequest : class
    {
        private readonly IDimeSchedulerRestClient<TRequest> _restClient;

        protected Endpoint(EndpointOptions opts)
            : this(new DimeSchedulerRestClient<TRequest>(opts))
        {
        }

        protected Endpoint(IDimeSchedulerRestClient<TRequest> restClient)
        {
            _restClient = restClient;
        }

        protected void Execute(string endpoint, Method method, TRequest requestParameters)
            => _restClient.Execute(endpoint, method, requestParameters);

        protected Task ExecuteAsync(string endpoint, Method method, TRequest requestParameters)
            => _restClient.ExecuteAsync(endpoint, method, requestParameters);

        protected T Execute<T>(string endpoint, Method method, TRequest requestParameters)
            => _restClient.Execute<T>(endpoint, method, requestParameters);

        protected Task<T> ExecuteAsync<T>(string endpoint, Method method, TRequest requestParameters)
            => _restClient.ExecuteAsync<T>(endpoint, method, requestParameters);

        protected T Execute<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters)
            => _restClient.Execute<T>(endpoint, method, requestParameters);

        protected Task<T> ExecuteAsync<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters)
            => _restClient.ExecuteAsync<T>(endpoint, method, requestParameters);
    }
}