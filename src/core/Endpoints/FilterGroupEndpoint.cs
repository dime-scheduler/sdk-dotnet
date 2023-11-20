using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.Sdk
{
    public class FilterGroupEndpoint : DefaultEndpoint<FilterGroup>, IFilterGroupEndpoint
    {
        public FilterGroupEndpoint(AuthenticationOptions opts)
            : base(Routes.Filter.Group, opts)
        {
        }
    }
}