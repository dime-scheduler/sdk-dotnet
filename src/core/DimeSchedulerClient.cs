namespace Dime.Scheduler.Sdk
{
    public class DimeSchedulerClient
    {
        public DimeSchedulerClient(AuthenticationOptions opts)
        {
            Import = new ImportEndpoint(opts);
            Messages = new MessagesEndpoint(opts);
            Users = new UsersEndpoint(opts);
            Resources = new ResourcesEndpoint(opts);
            License = new LicenseEndpoint(opts);
        }

        public IImportEndpoint Import { get; }
        public IMessageEndpoint Messages { get; }
        public UsersEndpoint Users { get; }
        public IResourceEndpoint Resources { get; }
        public ILicenseEndpoint License { get; }
    }
}