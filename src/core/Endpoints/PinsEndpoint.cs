namespace Dime.Scheduler.Sdk
{
    public class PinsEndpoint : DefaultEndpoint<IndicatorRequest>, IPinEndpoint
    {
        public PinsEndpoint(AuthenticationOptions opts)
            : base(Routes.Pin, opts)
        {
        }
    }
}