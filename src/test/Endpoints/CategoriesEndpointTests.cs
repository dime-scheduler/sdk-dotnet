using System.Threading.Tasks;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests
{
    public class CategoriesEndpointTests
    {
        [Fact]
        public async Task CategoriesEndpoint_MockClient_Create_ShouldCreate()
        {
            CategoriesEndpoint endpoint = new(new MockRestClient<IndicatorRequest>());
            await endpoint.Create(new IndicatorRequest());
        }

        [Fact]
        public async Task CategoriesEndpoint_MockClient_Update_ShouldUpdate()
        {
            CategoriesEndpoint endpoint = new(new MockRestClient<IndicatorRequest>());
            await endpoint.Update(new IndicatorRequest());
        }

        [Fact]
        public async Task CategoriesEndpoint_MockClient_Delete_ShouldDelete()
        {
            CategoriesEndpoint endpoint = new(new MockRestClient<IndicatorRequest>());
            await endpoint.Delete(new IndicatorRequest());
        }
    }
}
