using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class ImportEndpointService : EndpointService<ImportRequest>, IImportEndpointService
    {
        public ImportEndpointService(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public Task RunAsync(IImportRequestable requestParameters)
            => Execute(Routes.Import.InsertData, Method.POST, requestParameters.ToImportRequest());

        public Task<ImportSet> ProcessAsync(IImportRequestable requestParameters)
            => Execute<ImportSet>(Routes.Import.Insert, Method.POST, requestParameters.ToImportRequest());
    }
}