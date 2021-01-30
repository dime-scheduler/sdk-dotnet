using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskContainer : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}