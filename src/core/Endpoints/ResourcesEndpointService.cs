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
            Page<Resource> data = await Execute<Page<Resource>>("api/Resources/Get", Method.GET, request);
            return data.Data;
        }

        public Task<IEnumerable<Y>> GetAsync<Y>(ResourceRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task Create(ResourceRequest requestParameters)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(ResourceRequest requestParameters)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(ResourceRequest requestParameters)
        {
            throw new System.NotImplementedException();
        }
    }
}