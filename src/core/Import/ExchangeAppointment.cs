using System;
using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class ExchangeAppointment : IImportRequestable
    {
        public long AppointmentId { get; set; }

        public Guid? AppointmentGuid { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string Importance { get; set; }

        public string ResourceEmail { get; set; }

        public IEnumerable<string> Categories { get; set; } = new List<string>();

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertExchangeAppointment",
                ("AppointmentId", AppointmentId.ToString()),
                ("AppointmentGuid", AppointmentGuid?.ToString()),
                ("Start", Start.ToString("s") + ""),
                ("End", End.ToString("s") + ""),
                ("Subject", Subject),
                ("Body", Body),
                ("Importance", Importance),
                ("ResourceEmail", ResourceEmail),
                ("Categories", string.Join(";", Categories)));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deleteExchangeAppointment",
                new List<string>
                {
                    "AppointmentId",
                    "AppointmentGuid",
                    "Start",
                    "End",
                    "Subject",
                    "Body",
                    "Importance",
                    "ResourceEmail"
                }.ToArray(),
                new List<string>
                {
                    AppointmentId.ToString(),
                    AppointmentGuid?.ToString(),
                    Start.ToString("s") + "",
                    End.ToString("s") + "",
                    Subject,
                    Body,
                    Importance,
                    ResourceEmail
                }.ToArray());
    }
}