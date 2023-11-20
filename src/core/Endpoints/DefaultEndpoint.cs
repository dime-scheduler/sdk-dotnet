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

        public void Create(T requestParameters)
            => Execute(Route, Method.Post, requestParameters);

        public Task CreateAsync(T requestParameters)
            => ExecuteAsync(Route, Method.Post, requestParameters);

        public void Update(T requestParameters)
            => Execute(Route, Method.Put, requestParameters);

        public Task UpdateAsync(T requestParameters)
            => ExecuteAsync(Route, Method.Put, requestParameters);

        public void Delete(T requestParameters)
            => Execute(Route, Method.Delete, requestParameters);

        public Task DeleteAsync(T requestParameters)
            => ExecuteAsync(Route, Method.Delete, requestParameters);
    }
}