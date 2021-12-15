using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class LicenseEndpoint : Endpoint<LicenseRequest>, ILicenseEndpoint
    {
        public LicenseEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        internal LicenseEndpoint(IDimeSchedulerRestClient<LicenseRequest> restClient)
            : base(restClient)
        {
        }

        public async Task PostAsync(LicenseRequest request)
            => await Execute(Routes.License.Update, Method.PUT, request);
    }
}