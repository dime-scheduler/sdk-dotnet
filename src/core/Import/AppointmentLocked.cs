using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class AppointmentLocked : IImportRequestable
    {
        [ImportParameter(nameof(SourceApp))]
        public string SourceApp { get; set; }

        [ImportParameter(nameof(SourceType))]
        public string SourceType { get; set; }

        [ImportParameter(nameof(AppointmentId))]
        public long AppointmentId { get; set; }

        [ImportParameter(nameof(Locked))]
        public bool Locked { get; set; }

        [ImportParameter(nameof(AppointmentGuid))]
        public Guid? AppointmentGuid { get; set; }

        [ImportParameter(nameof(SentFromBackOffice))]
        public bool SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(ImportProcedures.Appointment.Locked.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException("Action does not exist yet in Dime.Scheduler");
    }
}