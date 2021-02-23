using System;
using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class AppointmentUri : IImportRequestable
    {
        public string SourceApp { get; set; }

        public string SourceType { get; set; }

        public long AppointmentId { get; set; }

        public Guid? AppointmentGuid { get; set; }

        public string Uri { get; set; }

        public string Description { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new(
                "mboc_upsertAppointmentUrl",
                new List<string> { "pSourceApp", "pSourceType", "pAppointmentId", "pAppointmentGuid", "pUrl", "pUrlDesc" }.ToArray(),
                new List<string> { SourceApp, SourceType, AppointmentId.ToString(), AppointmentGuid?.ToString(), Uri, Description }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException("Action does not exist yet in Dime.Scheduler");
    }
}