using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests
{
    public class CategoriesEndpointTests
    {
        [Fact]
        public async Task CategoriesEndpoint_MockClient_Create_ShouldCreate()
        {
            CategoriesEndpoint endpoint = new(new MockRestClient<CategoryRequest>());
            await endpoint.Create(new CategoryRequest());
        }

        [Fact]
        public async Task CategoriesEndpoint_MockClient_Update_ShouldUpdate()
        {
            CategoriesEndpoint endpoint = new(new MockRestClient<CategoryRequest>());
            await endpoint.Update(new CategoryRequest());
        }

        [Fact]
        public async Task CategoriesEndpoint_MockClient_Delete_ShouldDelete()
        {
            CategoriesEndpoint endpoint = new(new MockRestClient<CategoryRequest>());
            await endpoint.Delete(new CategoryRequest());
        }
    }
}
