using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class Resource : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}