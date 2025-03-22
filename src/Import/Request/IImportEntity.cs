namespace Dime.Scheduler.Entities
{
    public interface IImportEntity
    {
        ImportRequest ToImportRequest(TransactionType transactionType);
    }
}