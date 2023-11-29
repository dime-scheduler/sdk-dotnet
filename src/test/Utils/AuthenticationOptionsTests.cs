using Xunit;

namespace Dime.Scheduler.Tests.Utils
{
    public partial class EndpointOptionsTests
    {
        [Fact]
        public void EndpointOptions_Deconstruct_ShouldMapProperties()
        {
            EndpointOptions opts = new("https://www.mydimescheduler.com", "My$trongToken1!$$");

            (string uri, string authenticationToken) = opts;
            Assert.True(uri == "https://www.mydimescheduler.com");
            Assert.True(authenticationToken == "My$trongToken1!$$");
        }
    }
}