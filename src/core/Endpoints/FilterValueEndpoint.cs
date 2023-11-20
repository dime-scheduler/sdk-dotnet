using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.Sdk
{
    public class FilterValueEndpoint : DefaultEndpoint<FilterValue>, IFilterValueEndpoint
    {
        public FilterValueEndpoint(AuthenticationOptions opts)
            : base(Routes.Filter.Value, opts)
        {
        }
    }
}