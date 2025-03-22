using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    internal class FilterValueEndpoint : DefaultEndpoint<FilterValue>, IFilterValueEndpoint
    {
        internal FilterValueEndpoint(EndpointOptions opts) : base(Routes.Filter.Value, opts)
        {
        }
    }
}