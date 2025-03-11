using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    internal class ActionUriEndpoint : DefaultEndpoint<ActionUri>, IActionUriEndpoint
    {
        internal ActionUriEndpoint(EndpointOptions opts) : base(Routes.ActionUri, opts)
        {
        }
    }
}