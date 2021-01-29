namespace Dime.Scheduler.Sdk
{
    public class DimeSchedulerClient
    {
        public DimeSchedulerClient(string uri, IAuthenticator authenticator)
        {
            string baseUrl = uri.EnsureTrailingSlash();
            Import = new ImportEndpointBuilder(baseUrl, authenticator);
            Resources = new ResourcesEndpointBuilder(baseUrl, authenticator);
            Categories = new CategoriesEndpointBuilder(baseUrl, authenticator);
        }

        public IImportEndpointBuilder Import { get; }
        public IResourceEndpointBuilder Resources { get; }
        public ICategoryEndpointBuilder Categories { get; }
    }
}