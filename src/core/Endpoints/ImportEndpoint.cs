using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class ImportEndpoint : Endpoint<ImportRequest>, IImportEndpoint
    {
        public ImportEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public Task RunAsync(IImportRequestable requestParameters)
            => Execute(Routes.Import.InsertData, Method.POST, requestParameters.ToImportRequest());

        public Task<ImportSet> ProcessAsync(IImportRequestable requestParameters)
            => Execute<ImportSet>(Routes.Import.Insert, Method.POST, requestParameters.ToImportRequest());
    }
}