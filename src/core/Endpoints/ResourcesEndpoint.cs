namespace Dime.Scheduler.Sdk
{
    public class ResourcesEndpoint : Endpoint<ResourceRequest>, IResourceEndpoint
    {
        public ResourcesEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        internal ResourcesEndpoint(IDimeSchedulerRestClient<ResourceRequest> restClient)
            : base(restClient)
        {
        }
    }
}