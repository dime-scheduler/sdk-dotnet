using System;
using System.Collections.Generic;
using Dime.Scheduler.Sdk.Models.Exchange;

namespace Dime.Scheduler.Sdk.Models
{
    public class ExchangeAppointment : IImportRequestable
    {
        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentId/*'/>
        [ImportParameter(nameof(AppointmentId))]
        public long AppointmentId { get; set; }

        [ImportParameter(nameof(AppointmentGuid))]
        public Guid? AppointmentGuid { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentNo/*'/>
        public string AppointmentNo { get; set; }

        [ImportParameter(nameof(ExchangeId))]
        public string ExchangeId { get; set; }

        [ImportParameter(nameof(ICalUId))]
        public string ICalUId { get; set; }

        [ImportParameter(nameof(Start))]
        public DateTime Start { get; set; }

        [ImportParameter(nameof(End))]
        public DateTime End { get; set; }

        [ImportParameter(nameof(Subject))]
        public string Subject { get; set; }

        [ImportParameter(nameof(Body))]
        public string Body { get; set; }

        [ImportParameter(nameof(Importance))]
        public Importance Importance { get; set; }

        [ImportParameter(nameof(ResourceEmail))]
        public string ResourceEmail { get; set; }

        [ImportParameter(nameof(ShowAs))]
        public ShowAs ShowAs { get; set; }

        [ImportParameter(nameof(Sensitivity))]
        public Sensitivity Sensitivity { get; set; }

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
            => new(ImportProcedures.ExchangeAppointment.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.ExchangeAppointment.Delete, this.CreateParameters(TransactionType.Delete));
    }
}