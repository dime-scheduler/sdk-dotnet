using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskLocked : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}