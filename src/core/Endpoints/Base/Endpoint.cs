using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public abstract class Endpoint<TRequest> where TRequest : class
    {
        private readonly IDimeSchedulerRestClient<TRequest> _restClient;

        protected Endpoint(AuthenticationOptions opts) 
            : this(new DefaultDimeSchedulerRestClient<TRequest>(opts))
        {
        }

        protected Endpoint(IDimeSchedulerRestClient<TRequest> restClient)
        {
            _restClient = restClient;
        }

        protected Task Execute(string endpoint, Method method, TRequest requestParameters)
            => _restClient.Execute(endpoint, method, requestParameters);

        protected Task<T> Execute<T>(string endpoint, Method method, TRequest requestParameters)
            => _restClient.Execute<T>(endpoint, method, requestParameters);
    }
}