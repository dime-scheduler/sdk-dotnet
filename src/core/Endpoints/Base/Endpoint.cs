using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public abstract class Endpoint
    {
        private readonly AuthenticationOptions _opts;

        protected Endpoint(AuthenticationOptions opts)
        {
            _opts = opts;
        }

        protected Task<T> Execute<T>(string endpoint, Method method, T requestParameters)
        {
            IDimeSchedulerRestClient<T> restClient = new DefaultDimeSchedulerRestClient<T>(_opts);
            return restClient.Execute<T>(endpoint, method, requestParameters);
        }

        protected Task<T> Execute<T, TRequest>(string endpoint, Method method, TRequest requestParameters)
        {
            IDimeSchedulerRestClient<TRequest> restClient = new DefaultDimeSchedulerRestClient<TRequest>(_opts);
            return restClient.Execute<T>(endpoint, method, requestParameters);
        }
    }
}