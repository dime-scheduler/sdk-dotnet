namespace Dime.Scheduler.Sdk
{
    public class TimeMarkersEndpoint : DefaultEndpoint<IndicatorRequest>, ITimeMarkerEndpoint
    {
        public TimeMarkersEndpoint(AuthenticationOptions opts)
            : base(Routes.TimeMarker, opts)
        {
        }
    }
}