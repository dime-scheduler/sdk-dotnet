﻿using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler
{
    public abstract class DefaultEndpoint<T> : Endpoint<T> where T : class
    {
        protected DefaultEndpoint(string route, EndpointOptions opts) : base(opts)
        {
            Route = route;
        }

        private string Route { get; }

        public Task<Result> CreateAsync(T requestParameters)
            => ExecuteAsync(Route, Method.Post, requestParameters);

        public Task<Result> UpdateAsync(T requestParameters)
            => ExecuteAsync(Route, Method.Put, requestParameters);

        public Task<Result> DeleteAsync(T requestParameters)
            => ExecuteAsync(Route, Method.Delete, requestParameters);
    }
}