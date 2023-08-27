namespace Dime.Scheduler.Sdk
{
    public class CategoriesEndpoint : DefaultEndpoint<IndicatorRequest>, ICategoryEndpoint
    {
        public CategoriesEndpoint(AuthenticationOptions opts)
            : base(Routes.Category, opts)
        {
        }
    }
}