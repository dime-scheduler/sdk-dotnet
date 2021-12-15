using Dime.Scheduler.Sdk.Import;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IImportEndpoint : IEndpoint
    {
        t.Task RunAsync(IImportRequestable requestParameters, TransactionType transactionType);

        t.Task<ImportSet> ProcessAsync(IImportRequestable requestParameters, TransactionType transactionType);
    }
}