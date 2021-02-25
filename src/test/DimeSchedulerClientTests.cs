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
    }
}