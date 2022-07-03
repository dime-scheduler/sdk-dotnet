using System.Threading.Tasks;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests
{
    public partial class ResourcesEndpointTests
    {
        [Fact]
        public async Task ResourcesEndpoint_MockClient_Create_ShouldCreate()
        {
            ResourcesEndpoint endpoint = new(new MockRestClient<ResourceRequest>());
            await endpoint.GetAsync(new ResourceRequest());
        }
    }
}