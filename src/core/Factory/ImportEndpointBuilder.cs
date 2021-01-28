using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class ImportEndpointBuilder : EndpointBuilder<ImportEndpoint>, IImportEndpointBuilder
    {
        public ImportEndpointBuilder(string uri, IAuthenticator authn)
            : base(uri, authn)
        {
        }

        public async Task<IImportEndpoint> Request()
            => await Create();

        protected override ImportEndpoint Create(AuthenticationOptions opts)
            => new ImportEndpoint(opts);
    }
}