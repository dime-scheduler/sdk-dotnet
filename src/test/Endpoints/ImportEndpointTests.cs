using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests
{
    public partial class ImportEndpointTests
    {
        [Fact]
        public async t.Task ImportEndpoint_MockClient_Create_ShouldCreate()
        {
            ImportEndpoint endpoint = new(new MockRestClient<ImportRequest>());
            await endpoint.ProcessAsync(new ImportRequest(), TransactionType.Append);
        }

        [Fact]
        public async t.Task ImportEndpoint_TestClient_Create_ShouldCreate()
        {
            ImportEndpoint endpoint = new(new AuthenticationOptions("https://api-t.dimescheduler.com", "WRONG-KEY"));
            ImportSet result = await endpoint.ProcessAsync(new ImportRequest(), TransactionType.Append);

            Assert.True(result.Success == false);
        }
    }
}