using System;
using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class Notification : IImportRequestable
    {
        public string SourceApp { get; set; }

        public string SourceType { get; set; }

        public long AppointmentId { get; set; }

        public string MbocId { get; set; }

        public string Type { get; set; }

        public string Code { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        public string JobNo { get; set; }

        public string TaskNo { get; set; }

        public Guid AppointmentGuid { get; set; }

        public bool SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertNotification",
                new List<string> {
                    "SourceApp",
                    "SourceType",
                    "AppointmentId",
                    "mboc_id",
                    "NotificationType",
                    "NotificationCode",
                    "NotificationText",
                    "NotificationDate",
                    "JobNo",
                    "TaskNo",
                    "AppointmentGuid",
                    "SentFromBackOffice"
                }.ToArray(),
                new List<string>
                {
                    SourceApp,
                    SourceType,
                    AppointmentId.ToString(),
                    MbocId,
                    Type,
                    Code,
                    Text,
                    Date.ToString("s"),
                    JobNo,
                    TaskNo,
                    AppointmentGuid.ToString(),
                    SentFromBackOffice ? "1" : "0"
                }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deleteFilterValue",
                new List<string>
                {
                    "SourceApp",
                    "SourceType",
                    "AppointmentId",
                    "mboc_id",
                    "JobNo",
                    "TaskNo",
                    "AppointmentGuid",
                    "SentFromBackoffice"
                }.ToArray(),
                new List<string>
                {
                    SourceApp,
                    SourceType,
                    AppointmentId.ToString(),
                    MbocId,
                    JobNo,
                    TaskNo,
                    AppointmentGuid.ToString(),
                    SentFromBackOffice ? "1" : "0"
                }.ToArray());

    }
}