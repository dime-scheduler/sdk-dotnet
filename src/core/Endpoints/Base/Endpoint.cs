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

        protected T Execute<T>(string endpoint, Method method, T requestParameters)
        {
            IDimeSchedulerRestClient<T> restClient = new DimeSchedulerRestClient<T>(_opts);
            return restClient.Execute<T>(endpoint, method, requestParameters);
        }

        protected Task<T> ExecuteAsync<T>(string endpoint, Method method, T requestParameters)
        {
            IDimeSchedulerRestClient<T> restClient = new DimeSchedulerRestClient<T>(_opts);
            return restClient.ExecuteAsync<T>(endpoint, method, requestParameters);
        }

        protected T Execute<T, TRequest>(string endpoint, Method method, TRequest requestParameters)
        {
            IDimeSchedulerRestClient<TRequest> restClient = new DimeSchedulerRestClient<TRequest>(_opts);
            return restClient.Execute<T>(endpoint, method, requestParameters);
        }

        protected Task<T> ExecuteAsync<T, TRequest>(string endpoint, Method method, TRequest requestParameters)
        {
            IDimeSchedulerRestClient<TRequest> restClient = new DimeSchedulerRestClient<TRequest>(_opts);
            return restClient.ExecuteAsync<T>(endpoint, method, requestParameters);
        }
    }
}