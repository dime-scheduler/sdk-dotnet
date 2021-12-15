using System.Threading.Tasks;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests
{
    public class TimeMarkersEndpointTests
    {
        [Fact]
        public async Task TimeMarkersEndpoint_MockClient_Create_ShouldCreate()
        {
            TimeMarkersEndpoint endpoint = new(new MockRestClient<IndicatorRequest>());
            await endpoint.Create(new IndicatorRequest());
        }

        [Fact]
        public async Task TimeMarkersEndpoint_MockClient_Update_ShouldUpdate()
        {
            TimeMarkersEndpoint endpoint = new(new MockRestClient<IndicatorRequest>());
            await endpoint.Update(new IndicatorRequest());
        }

        [Fact]
        public async Task TimeMarkersEndpoint_MockClient_Delete_ShouldDelete()
        {
            TimeMarkersEndpoint endpoint = new(new MockRestClient<IndicatorRequest>());
            await endpoint.Delete(new IndicatorRequest());
        }
    }
}