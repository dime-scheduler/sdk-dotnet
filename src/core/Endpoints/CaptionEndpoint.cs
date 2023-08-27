namespace Dime.Scheduler.Sdk
{
    public class CaptionEndpoint : DefaultEndpoint<Import.Caption>, ICaptionEndpoint
    {
        public CaptionEndpoint(AuthenticationOptions opts)
            : base(Routes.Caption, opts)
        {
        }
    }
}