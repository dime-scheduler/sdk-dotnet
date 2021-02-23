using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class ResourcesEndpointBuilder : EndpointBuilder<ResourcesEndpoint>, IResourceEndpointBuilder
    {
        public ResourcesEndpointBuilder(string uri, IAuthenticator authn)
            : base(uri, authn)
        {
        }

        public async Task<IResourceEndpoint> Request()
            => await Create();

        protected override ResourcesEndpoint Create(AuthenticationOptions opts)
            => new(opts);
    }
}