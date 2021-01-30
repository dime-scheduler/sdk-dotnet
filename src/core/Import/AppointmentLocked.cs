using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class AppointmentLocked : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}