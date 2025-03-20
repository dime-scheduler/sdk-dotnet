namespace Dime.Scheduler
{
    public class IndicatorEndpoint
    {
        internal IndicatorEndpoint(EndpointOptions opts)
        {
            Pins = new PinsEndpoint(opts);
            TimeMarkers = new TimeMarkersEndpoint(opts);
            Categories = new CategoriesEndpoint(opts);
        }

        public IPinEndpoint Pins { get; }

        public ITimeMarkerEndpoint TimeMarkers { get; }

        public ICategoryEndpoint Categories { get; }
    }
}