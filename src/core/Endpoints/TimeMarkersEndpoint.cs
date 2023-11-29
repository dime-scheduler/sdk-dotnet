namespace Dime.Scheduler
{
    public class TimeMarkersEndpoint : DefaultEndpoint<Indicator>, ITimeMarkerEndpoint
    {
        public TimeMarkersEndpoint(EndpointOptions opts)
            : base(Routes.TimeMarker, opts)
        {
        }
    }
}