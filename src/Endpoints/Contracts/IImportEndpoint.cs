using System.Collections.Generic;
using Dime.Scheduler.Entities;
using t = System.Threading.Tasks;

namespace Dime.Scheduler
{
    public interface IImportEndpoint : IEndpoint
    {
        t.Task<ImportSet> ProcessAsync(IEnumerable<IImportEntity> requestParameters, TransactionType transactionType);

        t.Task<ImportSet> ProcessAsync(IImportEntity requestParameters, TransactionType transactionType);
    }
}