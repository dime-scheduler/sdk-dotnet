using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.Sdk
{
    public class ActionUriEndpoint : DefaultEndpoint<ActionUri>, IActionUriEndpoint
    {
        public ActionUriEndpoint(AuthenticationOptions opts)
            : base(Routes.ActionUri, opts)
        {
        }
    }
}