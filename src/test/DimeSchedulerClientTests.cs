using System.Threading.Tasks;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests
{
    public class DimeSchedulerClientTests
    {
        [Fact]
        public void DimeSchedulerClient_Constructor_ShouldCreate()
        {
            const string uri = "http://mydimescheduler.io";
            IAuthenticator authenticator = new MockAuthenticator();
            DimeSchedulerClient client = new(uri, authenticator);

            Assert.NotNull(client);
        }

        [Fact]
        public async Task DimeSchedulerClient_ImportEndpoint_ShouldCreate()
        {
            const string uri = "http://mydimescheduler.io";
            IAuthenticator authenticator = new MockAuthenticator();
            DimeSchedulerClient client = new(uri, authenticator);

            IImportEndpoint endpoint = await client.Import.Request();
            Assert.NotNull(endpoint);
        }

        [Fact]
        public async Task DimeSchedulerClient_ResourcesEndpoint_ShouldCreate()
        {
            const string uri = "http://mydimescheduler.io";
            IAuthenticator authenticator = new MockAuthenticator();
            DimeSchedulerClient client = new(uri, authenticator);

            IResourceEndpoint endpoint = await client.Resources.Request();
            Assert.NotNull(endpoint);
        }

        [Fact]
        public async Task DimeSchedulerClient_CategoriesEndpoint_ShouldCreate()
        {
            const string uri = "http://mydimescheduler.io";
            IAuthenticator authenticator = new MockAuthenticator();
            DimeSchedulerClient client = new(uri, authenticator);

            ICrudEndpoint<IndicatorRequest> endpoint = await client.Categories.Request();
            Assert.NotNull(endpoint);
        }

        [Fact]
        public async Task DimeSchedulerClient_MessageEndpoint_ShouldCreate()
        {
            const string uri = "http://mydimescheduler.io";
            IAuthenticator authenticator = new MockAuthenticator();
            DimeSchedulerClient client = new(uri, authenticator);

            IMessageEndpoint endpoint = await client.Messages.Request();
            Assert.NotNull(endpoint);
        }
    }
}