namespace Dime.Scheduler
{
    public class CategoriesEndpoint : DefaultEndpoint<Indicator>, ICategoryEndpoint
    {
        public CategoriesEndpoint(EndpointOptions opts)
            : base(Routes.Category, opts)
        {
        }
    }
}