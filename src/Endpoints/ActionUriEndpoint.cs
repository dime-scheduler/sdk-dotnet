using System.Threading.Tasks;
using Dime.Scheduler.Entities;
using RestSharp;

namespace Dime.Scheduler
{
    internal class ActionUriEndpoint : DefaultEndpoint<ActionUri>, IActionUriEndpoint
    {
        internal ActionUriEndpoint(EndpointOptions opts) : base(Routes.ActionUri, opts)
        {
        }

        public override Task<Result> CreateAsync(ActionUri requestParameters)
            => ExecuteAsync(Route, Method.Post, requestParameters, true);

        public override Task<Result> UpdateAsync(ActionUri requestParameters)
            => ExecuteAsync(Route, Method.Put, requestParameters, true);

        public override Task<Result> DeleteAsync(ActionUri requestParameters)
            => ExecuteAsync(Route, Method.Delete, requestParameters, true);
    }
}