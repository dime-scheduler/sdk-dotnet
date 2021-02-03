using System;
using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class ExchangeAppointment : IImportRequestable
    {
        [ImportParameter(nameof(AppointmentId))]
        public long AppointmentId { get; set; }

        [ImportParameter(nameof(AppointmentGuid))]
        public Guid? AppointmentGuid { get; set; }

        [ImportParameter(nameof(Start))]
        public DateTime Start { get; set; }

        [ImportParameter(nameof(End))]
        public DateTime End { get; set; }

        [ImportParameter(nameof(Subject))]
        public string Subject { get; set; }

        [ImportParameter(nameof(Body))]
        public string Body { get; set; }

        [ImportParameter(nameof(Importance))]
        public string Importance { get; set; }

        [ImportParameter(nameof(ResourceEmail))]
        public string ResourceEmail { get; set; }

        [ImportParameter(nameof(Categories))]
        public IEnumerable<string> Categories { get; set; } = new List<string>();

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(ImportProcedures.ExchangeAppointment.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(ImportProcedures.ExchangeAppointment.Delete, this.CreateParameters(TransactionType.Delete));
    }
}