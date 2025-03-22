using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler
{
    internal abstract class DefaultEndpoint<T> : Endpoint<T> where T : class
    {
        protected DefaultEndpoint(string route, EndpointOptions opts) : base(opts)
        {
            Route = route;
        }

        protected string Route { get; }

        public virtual Task<Result> CreateAsync(T requestParameters)
            => ExecuteAsync(Route, Method.Post, requestParameters);

        public virtual Task<Result> UpdateAsync(T requestParameters)
            => ExecuteAsync(Route, Method.Put, requestParameters);

        public virtual Task<Result> DeleteAsync(T requestParameters)
            => ExecuteAsync(Route, Method.Delete, requestParameters);
    }
}