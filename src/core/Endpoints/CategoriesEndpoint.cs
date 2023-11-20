namespace Dime.Scheduler.Sdk
{
    public class CategoriesEndpoint : DefaultEndpoint<Indicator>, ICategoryEndpoint
    {
        public CategoriesEndpoint(AuthenticationOptions opts)
            : base(Routes.Category, opts)
        {
        }
    }
}