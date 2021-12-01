using System.Threading.Tasks;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests
{
    public class LicenseEndpointTests
    {
        [Fact]
        public async Task LicenseEndpoint_MockClient_Create_ShouldCreate()
        {
            LicenseEndpoint endpoint = new(new MockRestClient<LicenseRequest>());
            await endpoint.PostAsync(new LicenseRequest());
        }
    }
}