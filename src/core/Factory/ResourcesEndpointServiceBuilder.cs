using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class ResourcesEndpointServiceBuilder : EndpointServiceBuilder<ResourcesEndpointService>, IResourceEndpointServiceBuilder
    {
        public ResourcesEndpointServiceBuilder(string uri, IAuthenticator authn)
            : base(uri, authn)
        {
        }

        public async Task<IResourceEndpointService> Request()
            => await Create();

        protected override ResourcesEndpointService Create(AuthenticationOptions opts)
            => new ResourcesEndpointService(opts);
    }
}