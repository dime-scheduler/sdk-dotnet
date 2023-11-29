using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public class FilterGroupEndpoint : DefaultEndpoint<FilterGroup>, IFilterGroupEndpoint
    {
        public FilterGroupEndpoint(EndpointOptions opts)
            : base(Routes.Filter.Group, opts)
        {
        }
    }
}