namespace Dime.Scheduler
{
    public class FilterEndpoint
    {
        internal FilterEndpoint(EndpointOptions opts)
        {
            Groups = new FilterGroupEndpoint(opts);
            Values = new FilterValueEndpoint(opts);
        }

        public IFilterGroupEndpoint Groups { get; }

        public IFilterValueEndpoint Values { get; }
    }
}