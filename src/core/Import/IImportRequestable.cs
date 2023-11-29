namespace Dime.Scheduler.Entities
{
    public interface IImportRequestable
    {
        ImportRequest ToImportRequest(TransactionType transactionType);
    }
}