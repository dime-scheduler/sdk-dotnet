using System;
using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class AppointmentImportance : IImportRequestable
    {
        public string SourceApp { get; set; }

        public string SourceType { get; set; }

        public long AppointmentId { get; set; }

        public string Importance { get; set; }

        public Guid? AppointmentGuid { get; set; }

        public bool SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertAppointmentImportance",
                new List<string> { "SourceApp", "SourceType", "AppointmentId", "Importance", "AppointmentGuid", "SentFromBackOffice" }.ToArray(),
                new List<string> { SourceApp, SourceType, AppointmentId.ToString(), Importance, AppointmentGuid?.ToString(), SentFromBackOffice.ToBit().ToString() }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException("Action does not exist yet in Dime.Scheduler");

    }
}