namespace Dime.Scheduler
{
    internal class CategoriesEndpoint : DefaultEndpoint<Indicator>, ICategoryEndpoint
    {
        internal CategoriesEndpoint(EndpointOptions opts) : base(Routes.Category, opts)
        {
        }
    }
}