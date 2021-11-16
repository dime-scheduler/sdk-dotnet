namespace Dime.Scheduler.Sdk
{
    public class DimeSchedulerClient
    {
        public DimeSchedulerClient(string uri, IAuthenticator authenticator)
        {
            string baseUrl = uri.EnsureTrailingSlash();
            Import = new ImportEndpointBuilder(baseUrl, authenticator);
            Messages = new MessagesEndpointBuilder(baseUrl, authenticator);
            Resources = new ResourcesEndpointBuilder(baseUrl, authenticator);
        }

        public IImportEndpointBuilder Import { get; }
        public IMessageEndpointBuilder Messages { get; }
        public IResourceEndpointBuilder Resources { get; }
    }
}