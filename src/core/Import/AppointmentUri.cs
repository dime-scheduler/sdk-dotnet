using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class AppointmentUri : IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
        {
            throw new NotImplementedException();
        }
    }
}