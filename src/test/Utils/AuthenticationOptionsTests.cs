using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Utils
{
    public class AuthenticationOptionsTests
    {
        [Fact]
        public void AuthenticationOptions_Deconstruct_ShouldMapProperties()
        {
            AuthenticationOptions opts = new("https://www.mydimescheduler.com", "My$trongToken1!$$");

            (string uri, string authenticationToken) = opts;
            Assert.True(uri == "https://www.mydimescheduler.com");
            Assert.True(authenticationToken == "My$trongToken1!$$");
        }
    }
}