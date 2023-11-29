namespace Dime.Scheduler
{
    public class PinsEndpoint : DefaultEndpoint<Indicator>, IPinEndpoint
    {
        public PinsEndpoint(EndpointOptions opts)
            : base(Routes.Pin, opts)
        {
        }
    }
}