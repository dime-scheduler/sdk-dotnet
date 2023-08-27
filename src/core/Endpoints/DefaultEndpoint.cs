using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public abstract class DefaultEndpoint<T> : Endpoint<T> where T : class
    {
        protected DefaultEndpoint(string route, AuthenticationOptions opts) : base(opts)
        {
            Route = route;
        }

        private string Route { get; }

        public Task Create(T requestParameters)
            => Execute(Route, Method.Post, requestParameters);

        public Task Update(T requestParameters)
            => Execute(Route, Method.Post, requestParameters);

        public Task Delete(T requestParameters)
            => Execute(Route, Method.Post, requestParameters);
    }
}