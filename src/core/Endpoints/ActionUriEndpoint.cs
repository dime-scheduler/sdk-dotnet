using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public class ActionUriEndpoint : DefaultEndpoint<ActionUri>, IActionUriEndpoint
    {
        public ActionUriEndpoint(EndpointOptions opts)
            : base(Routes.ActionUri, opts)
        {
        }
    }
}