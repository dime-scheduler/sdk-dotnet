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

        public t.Task RunAsync(IImportRequestable requestParameters, TransactionType transactionType)
            => Execute(Routes.Import.InsertData, Method.POST, requestParameters.ToImportRequest(transactionType));

        public t.Task<ImportSet> ProcessAsync(IImportRequestable requestParameters, TransactionType transactionType)
            => Execute<ImportSet>(Routes.Import.Insert, Method.POST, requestParameters.ToImportRequest(transactionType));
    }
}