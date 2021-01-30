using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class Appointment : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}