using t = System.Threading.Tasks;
using Dime.Scheduler.Sdk.Import;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class ImportEndpoint : Endpoint<ImportRequest>, IImportEndpoint
    {
        public ImportEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public t.Task RunAsync(IImportRequestable requestParameters)
            => Execute(Routes.Import.InsertData, Method.POST, requestParameters.ToImportRequest());

        public t.Task<ImportSet> ProcessAsync(IImportRequestable requestParameters)
            => Execute<ImportSet>(Routes.Import.Insert, Method.POST, requestParameters.ToImportRequest());
    }
}