using System.Threading.Tasks;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests
{
    public partial class UsersEndpointTests
    {
        [Fact]
        public async Task UsersEndpoint_MockClient_Create_ShouldCreate()
        {
            UsersEndpoint endpoint = new(new MockRestClient<UserRequest>());
            await endpoint.Create(new UserRequest());
        }

        [Fact]
        public async Task UsersEndpoint_MockClient_Update_ShouldUpdate()
        {
            UsersEndpoint endpoint = new(new MockRestClient<UserRequest>());
            await endpoint.Update(new UserRequest());
        }

        [Fact]
        public async Task UsersEndpoint_MockClient_Delete_ShouldDelete()
        {
            UsersEndpoint endpoint = new(new MockRestClient<UserRequest>());
            await endpoint.Delete(new UserRequest());
        }
    }
}