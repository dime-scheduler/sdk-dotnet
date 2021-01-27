using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class ResourcesEndpointService : EndpointService<ResourceRequest>, IResourceEndpointService
    {
        public ResourcesEndpointService(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public async Task<IEnumerable<Resource>> GetAsync(ResourceRequest request)
        {
            Page<Resource> data = await Execute<Page<Resource>>(Routes.Resources.Get, Method.GET, request);
            return data.Data;
        }
    }
}