using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    internal class FilterGroupEndpoint : DefaultEndpoint<FilterGroup>, IFilterGroupEndpoint
    {
        internal FilterGroupEndpoint(EndpointOptions opts) : base(Routes.Filter.Group, opts)
        {
        }
    }
}