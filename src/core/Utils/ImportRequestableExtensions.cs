using System.Collections.Generic;
using System.Linq;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.Sdk
{
    internal static class ImportRequestableExtensions
    {
        internal static IEnumerable<ImportRequest> ToImportRequest(this IEnumerable<IImportRequestable> requests, TransactionType transactionType)
            => requests.Select(x => x.ToImportRequest(transactionType));
    }
}