using t = System.Threading.Tasks;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.Sdk
{
    public interface IImportEndpoint : IEndpoint
    {
        t.Task RunAsync(IImportRequestable requestParameters, TransactionType transactionType);

        t.Task<ImportSet> ProcessAsync(IImportRequestable requestParameters, TransactionType transactionType);
    }
}