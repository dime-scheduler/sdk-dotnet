using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk.Tests
{
    public partial class MockRestClient<TRequest> : IDimeSchedulerRestClient<TRequest>
    {
        public Task Execute(string endpoint, Method method, TRequest requestParameters)
            => Task.FromResult(0);

        public Task<T> Execute<T>(string endpoint, Method method, TRequest requestParameters)
            => Task.FromResult(default(T));

        public Task<T> Execute<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters)
            => Task.FromResult(default(T));
    }
}