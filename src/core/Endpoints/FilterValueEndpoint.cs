using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public class FilterValueEndpoint : DefaultEndpoint<FilterValue>, IFilterValueEndpoint
    {
        public FilterValueEndpoint(EndpointOptions opts)
            : base(Routes.Filter.Value, opts)
        {
        }
    }
}