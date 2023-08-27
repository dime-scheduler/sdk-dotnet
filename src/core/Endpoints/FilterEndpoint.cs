namespace Dime.Scheduler.Sdk
{
    public class FilterEndpoint : DefaultEndpoint<Import.FilterGroup>, IFilterEndpoint
    {
        public FilterEndpoint(AuthenticationOptions opts)
            : base(Routes.Filter.Group, opts)
        {
        }
    }
}