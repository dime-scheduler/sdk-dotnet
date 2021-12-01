using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class LicensesEndpointBuilder : EndpointBuilder<LicenseEndpoint>, ILicenseEndpointBuilder
    {
        public LicensesEndpointBuilder(string uri, IAuthenticator authn)
            : base(uri, authn)
        {
        }

        public async Task<ILicenseEndpoint> Request()
         => await Create();

        protected override LicenseEndpoint Create(AuthenticationOptions opts)
        => new(opts);
    }
}