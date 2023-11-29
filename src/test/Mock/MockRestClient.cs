using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Tests
{
    public partial class MockRestClient<TRequest> : IDimeSchedulerRestClient<TRequest>
    {
        public Task Execute(string endpoint, Method method, TRequest requestParameters)
            => Task.FromResult(0);

        public Task<T> Execute<T>(string endpoint, Method method, TRequest requestParameters)
            => Task.FromResult(default(T));

        public Task<T> Execute<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters)
            => Task.FromResult(default(T));

        public Task ExecuteAsync(string endpoint, Method method, TRequest requestParameters)
              => Task.FromResult(0);

        public Task<T> ExecuteAsync<T>(string endpoint, Method method, TRequest requestParameters)
            => Task.FromResult(default(T));

        public Task<T> ExecuteAsync<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters)
            => Task.FromResult(default(T));

        void IDimeSchedulerRestClient<TRequest>.Execute(string endpoint, Method method, TRequest requestParameters)
        {
        }

        T IDimeSchedulerRestClient<TRequest>.Execute<T>(string endpoint, Method method, TRequest requestParameters)
            => default(T);

        T IDimeSchedulerRestClient<TRequest>.Execute<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters)
            => default(T);
    }
}