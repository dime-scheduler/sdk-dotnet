namespace Dime.Scheduler
{
    internal class TimeMarkersEndpoint : DefaultEndpoint<Indicator>, ITimeMarkerEndpoint
    {
        internal TimeMarkersEndpoint(EndpointOptions opts) : base(Routes.TimeMarker, opts)
        {
        }
    }
}