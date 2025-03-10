using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler
{
    public abstract class Endpoint<TRequest> : Endpoint where TRequest : class
    {
        protected Endpoint(EndpointOptions opts) : base(opts)
        {
        }

        protected Task<Result> ExecuteAsync(string endpoint, Method method, TRequest requestParameters)
            => base.ExecuteAsync(endpoint, method, requestParameters);
    }
}