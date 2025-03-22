using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    internal class CaptionEndpoint : DefaultEndpoint<Caption>, ICaptionEndpoint
    {
        internal CaptionEndpoint(EndpointOptions opts) : base(Routes.Caption, opts)
        {
        }
    }
}