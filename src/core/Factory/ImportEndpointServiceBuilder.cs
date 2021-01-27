using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class ImportEndpointServiceBuilder : EndpointServiceBuilder<ImportEndpointService>, IImportEndpointServiceBuilder
    {
        public ImportEndpointServiceBuilder(string uri, IAuthenticator authn)
            : base(uri, authn)
        {
        }

        public async Task<IImportEndpointService> Request()
            => await Create();

        protected override ImportEndpointService Create(AuthenticationOptions opts)
            => new ImportEndpointService(opts);
    }
}