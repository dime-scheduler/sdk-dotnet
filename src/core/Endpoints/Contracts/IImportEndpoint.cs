using System.Collections.Generic;
using Dime.Scheduler.Sdk.Models;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IImportEndpoint : IEndpoint
    {
        t.Task<ImportSet> ProcessAsync(IEnumerable<IImportRequestable> requestParameters, TransactionType transactionType);

        t.Task<ImportSet> ProcessAsync(IImportRequestable requestParameters, TransactionType transactionType);
    }
}