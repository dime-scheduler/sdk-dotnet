using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceCapacity : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}