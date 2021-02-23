using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class Notification : IImportRequestable
    {
        [ImportParameter(nameof(SourceApp))]
        [RequiredIf(TransactionType.Append)]
        public string SourceApp { get; set; }

        [ImportParameter(nameof(SourceType))]
        [RequiredIf(TransactionType.Append)]
        public string SourceType { get; set; }

        [ImportParameter(nameof(AppointmentId))]
        public long? AppointmentId { get; set; }

        [ImportParameter("mboc_id")]
        public string MbocId { get; set; }

        [ImportParameter("NotificationType", TransactionType.Append)]
        public string Type { get; set; }

        [ImportParameter("NotificationCode", TransactionType.Append)]
        public string Code { get; set; }

        [ImportParameter("NotificationText", TransactionType.Append)]
        public string Text { get; set; }

        [ImportParameter("NotificationDate", TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        public DateTime? Date { get; set; }

        [ImportParameter(nameof(JobNo))]
        public string JobNo { get; set; }

        [ImportParameter(nameof(TaskNo))]
        public string TaskNo { get; set; }

        [ImportParameter(nameof(AppointmentGuid))]
        public Guid AppointmentGuid { get; set; }

        [ImportParameter("SentFromBackoffice")]
        public bool SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Notification.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Notification.Delete, this.CreateParameters(TransactionType.Delete));
    }
}