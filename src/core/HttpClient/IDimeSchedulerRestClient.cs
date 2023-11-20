using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public interface IDimeSchedulerRestClient<in TRequest>
    {
        void Execute(string endpoint, Method method, TRequest requestParameters);

        Task ExecuteAsync(string endpoint, Method method, TRequest requestParameters);

        T Execute<T>(string endpoint, Method method, TRequest requestParameters);

        Task<T> ExecuteAsync<T>(string endpoint, Method method, TRequest requestParameters);

        T Execute<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters);

        Task<T> ExecuteAsync<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters);
    }
}