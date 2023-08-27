namespace Dime.Scheduler.Sdk
{
    public class ActionUriEndpoint : DefaultEndpoint<Import.ActionUri>, IActionUriEndpoint
    {
        public ActionUriEndpoint(AuthenticationOptions opts)
            : base(Routes.ActionUri, opts)
        {
        }
    }
}