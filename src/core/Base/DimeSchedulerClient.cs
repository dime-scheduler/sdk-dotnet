namespace Dime.Scheduler.Sdk
{
    public class DimeSchedulerClient
    {
        public DimeSchedulerClient(string uri, IAuthenticator authenticator)
        {
            string baseUrl = uri.EnsureTrailingSlash();
            Import = new ImportEndpointServiceBuilder(baseUrl, authenticator);
            Resources = new ResourcesEndpointServiceBuilder(baseUrl, authenticator);
            Categories = new CategoriesEndpointServiceBuilder(baseUrl, authenticator);
        }

        public IImportEndpointServiceBuilder Import { get; }
        public IResourceEndpointServiceBuilder Resources { get; }
        public ICategoryEndpointServiceBuilder Categories { get; }
    }
}