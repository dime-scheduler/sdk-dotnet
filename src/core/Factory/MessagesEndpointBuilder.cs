using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class MessagesEndpointBuilder : EndpointBuilder<MessagesEndpoint>, IMessageEndpointBuilder
    {
        public MessagesEndpointBuilder(string uri, IAuthenticator authn)
            : base(uri, authn)
        {
        }

        public async Task<IMessageEndpoint> Request()
         => await Create();

        protected override MessagesEndpoint Create(AuthenticationOptions opts)
        => new MessagesEndpoint(opts);
    }
}