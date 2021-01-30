using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class AppointmentCategory : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}