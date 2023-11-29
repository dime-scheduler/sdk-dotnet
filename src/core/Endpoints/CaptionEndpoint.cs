using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public class CaptionEndpoint : DefaultEndpoint<Caption>, ICaptionEndpoint
    {
        public CaptionEndpoint(EndpointOptions opts)
            : base(Routes.Caption, opts)
        {
        }
    }
}