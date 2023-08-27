namespace Dime.Scheduler.Sdk
{
    public class FilterGroupEndpoint : DefaultEndpoint<Import.FilterGroup>, IFilterGroupEndpoint
    {
        public FilterGroupEndpoint(AuthenticationOptions opts)
            : base(Routes.Filter.Group, opts)
        {
        }
    }
}