using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class UsersEndpointBuilder : EndpointBuilder<UsersEndpoint>, IUserEndpointBuilder
    {
        public UsersEndpointBuilder(string uri, IAuthenticator authn)
            : base(uri, authn)
        {
        }

        public async Task<ICrudEndpoint<IndicatorRequest>> Request()
         => await Create();

        protected override UsersEndpoint Create(AuthenticationOptions opts)
        => new(opts);
    }
}