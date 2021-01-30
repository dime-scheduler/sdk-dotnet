using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceCertificate : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}