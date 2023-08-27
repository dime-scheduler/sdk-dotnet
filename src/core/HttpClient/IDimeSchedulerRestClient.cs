using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public interface IDimeSchedulerRestClient<in TRequest>
    {
        Task Execute(string endpoint, Method method, TRequest requestParameters);

        Task<T> Execute<T>(string endpoint, Method method, TRequest requestParameters);

        Task<T> Execute<T>(string endpoint, Method method, IEnumerable<TRequest> requestParameters);
    }
}