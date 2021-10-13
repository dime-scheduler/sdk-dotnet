using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{

    public class PinsEndpointBuilder : EndpointBuilder<PinsEndpoint>, IPinEndpointBuilder
    {
        public PinsEndpointBuilder(string uri, IAuthenticator authn)
            : base(uri, authn)
        {
        }

        public async Task<ICrudEndpoint<IndicatorRequest>> Request()
         => await Create();

        protected override PinsEndpoint Create(AuthenticationOptions opts)
        => new(opts);
    }
}