using System.Collections.Generic;
using Dime.Scheduler.Sdk.Import;
using RestSharp;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class ImportEndpoint : Endpoint<ImportRequest>, IImportEndpoint
    {
        public ImportEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public t.Task<ImportSet> ProcessAsync(IEnumerable<IImportRequestable> requestParameters, TransactionType transactionType)
            => Execute<ImportSet>(Routes.Import.InsertData, Method.POST, requestParameters.ToImportRequest(transactionType));

        public t.Task<ImportSet> ProcessAsync(IImportRequestable requestParameters, TransactionType transactionType)
            => Execute<ImportSet>(Routes.Import.Insert, Method.POST, requestParameters.ToImportRequest(transactionType));
    }
}