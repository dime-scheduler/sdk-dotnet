using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class AppointmentImportance : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}