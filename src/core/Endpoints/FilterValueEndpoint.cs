namespace Dime.Scheduler.Sdk
{
    public class FilterValueEndpoint : DefaultEndpoint<Import.FilterValue>, IFilterValueEndpoint
    {
        public FilterValueEndpoint(AuthenticationOptions opts)
            : base(Routes.Filter.Value, opts)
        {
        }
    }
}