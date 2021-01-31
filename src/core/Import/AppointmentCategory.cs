using System;
using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class AppointmentCategory : IImportRequestable
    {
        public string SourceApp { get; set; }

        public string SourceType { get; set; }

        public long AppointmentId { get; set; }

        public string Category { get; set; }

        public Guid? AppointmentGuid { get; set; }

        public bool SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertAppointmentCategory",
                new List<string> { "SourceApp", "SourceType", "AppointmentId", "Category", "AppointmentGuid", "SentFromBackOffice"}.ToArray(),
                new List<string> { SourceApp, SourceType, AppointmentId.ToString(), Category, AppointmentGuid?.ToString(), SentFromBackOffice.ToBit().ToString() }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException("Action does not exist yet in Dime.Scheduler");
    }
}