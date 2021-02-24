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
        private readonly IDimeSchedulerRestClient<TRequest> _restClient;

        protected Endpoint(AuthenticationOptions opts)
            : this(opts, new DefaultDimeSchedulerRestClient<TRequest>(opts))
        {
        }

        protected Endpoint(AuthenticationOptions opts, IDimeSchedulerRestClient<TRequest> restClient)
        {
            _restClient = restClient;
            _opts = opts;
        }

        protected Task Execute(string endpoint, Method method, TRequest requestParameters)
            => _restClient.Execute(endpoint, method, requestParameters);

        protected Task<T> Execute<T>(string endpoint, Method method, TRequest requestParameters)
                => _restClient.Execute<T>(endpoint, method, requestParameters);
    }
}