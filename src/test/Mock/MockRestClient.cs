using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk.Tests
{
    public class MockRestClient<TRequest> : IDimeSchedulerRestClient<TRequest>
    {
        public Task Execute(string endpoint, Method method, TRequest requestParameters)
            => Task.FromResult(0);

        public Task<T> Execute<T>(string endpoint, Method method, TRequest requestParameters)
            => Task.FromResult(default(T));
    }
}