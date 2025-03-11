namespace Dime.Scheduler
{
    internal class PinsEndpoint : DefaultEndpoint<Indicator>, IPinEndpoint
    {
        internal PinsEndpoint(EndpointOptions opts) : base(Routes.Pin, opts)
        {
        }
    }
}