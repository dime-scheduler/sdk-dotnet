using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests
{
    internal class MockAuthenticator : IAuthenticator
    {
        public Task<string> AuthenticateAsync()
        {
            return Task.FromResult("token_12345");
        }
    }
}