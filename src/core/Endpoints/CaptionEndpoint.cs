using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.Sdk
{
    public class CaptionEndpoint : DefaultEndpoint<Caption>, ICaptionEndpoint
    {
        public CaptionEndpoint(AuthenticationOptions opts)
            : base(Routes.Caption, opts)
        {
        }
    }
}