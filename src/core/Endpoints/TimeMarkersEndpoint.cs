namespace Dime.Scheduler.Sdk
{
    public class TimeMarkersEndpoint : DefaultEndpoint<Indicator>, ITimeMarkerEndpoint
    {
        public TimeMarkersEndpoint(AuthenticationOptions opts)
            : base(Routes.TimeMarker, opts)
        {
        }
    }
}