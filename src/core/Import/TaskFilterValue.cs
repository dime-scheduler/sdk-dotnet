using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskFilterValue : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}