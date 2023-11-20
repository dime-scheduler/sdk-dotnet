namespace Dime.Scheduler.Sdk.Models
{
    public interface IImportRequestable
    {
        ImportRequest ToImportRequest(TransactionType transactionType);
    }
}