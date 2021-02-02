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
                new ImportParameter("AppointmentId", AppointmentId.ToString()),
                new ImportParameter("AppointmentGuid", AppointmentGuid?.ToString()),
                new ImportParameter("Start", Start.ToString("s") + ""),
                new ImportParameter("End", End.ToString("s") + ""),
                new ImportParameter("Subject", Subject),
                new ImportParameter("Body", Body),
                new ImportParameter("Importance", Importance),
                new ImportParameter("ResourceEmail", ResourceEmail),
                new ImportParameter("Categories", string.Join(";", Categories)));

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