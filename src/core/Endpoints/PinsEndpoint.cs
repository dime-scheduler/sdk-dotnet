namespace Dime.Scheduler.Sdk
{
    public class PinsEndpoint : DefaultEndpoint<Indicator>, IPinEndpoint
    {
        public PinsEndpoint(AuthenticationOptions opts)
            : base(Routes.Pin, opts)
        {
        }
    }
}