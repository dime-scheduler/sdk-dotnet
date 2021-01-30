using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceUri : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}