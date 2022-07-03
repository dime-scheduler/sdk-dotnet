using System.Threading.Tasks;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests
{
    public partial class MessagesEndpointTests
    {
        [Fact]
        public async Task MessagesEndpoint_MockClient_Create_ShouldCreate()
        {
            MessagesEndpoint endpoint = new(new MockRestClient<MessageRequest>());
            await endpoint.PostAsync(new MessageRequest());
        }
    }
}