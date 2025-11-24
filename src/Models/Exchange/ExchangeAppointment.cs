using System;
using System.Collections.Generic;
using Dime.Scheduler.Entities.Exchange;

namespace Dime.Scheduler.Entities
{
    public class ExchangeAppointment : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentId/*'/>
        [ImportParameter(nameof(AppointmentId))]
        public long AppointmentId { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentGuid/*'/>
        [ImportParameter(nameof(AppointmentGuid))]
        public Guid? AppointmentGuid { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentNo/*'/>
        public string AppointmentNo { get; set; }

        /// <summary>
        /// The Exchange identifier.
        /// </summary>
        [ImportParameter(nameof(ExchangeId))]
        public string ExchangeId { get; set; }

        /// <summary>
        /// The iCal UID.
        /// </summary>
        [ImportParameter(nameof(ICalUId))]
        public string ICalUId { get; set; }

        /// <summary>
        /// The start date and time.
        /// </summary>
        [ImportParameter(nameof(Start))]
        public DateTime Start { get; set; }

        /// <summary>
        /// The end date and time.
        /// </summary>
        [ImportParameter(nameof(End))]
        public DateTime End { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Subject/*'/>
        [ImportParameter(nameof(Subject))]
        public string Subject { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Body/*'/>
        [ImportParameter(nameof(Body))]
        public string Body { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Importance/*'/>
        [ImportParameter(nameof(Importance))]
        public Importance Importance { get; set; }

        /// <summary>
        /// The resource email address.
        /// </summary>
        [ImportParameter(nameof(ResourceEmail))]
        public string ResourceEmail { get; set; }

        /// <summary>
        /// how the appointment should be displayed.
        /// </summary>
        [ImportParameter(nameof(ShowAs))]
        public ShowAs ShowAs { get; set; }

        /// <summary>
        /// The sensitivity level of the appointment.
        /// </summary>
        [ImportParameter(nameof(Sensitivity))]
        public Sensitivity Sensitivity { get; set; }

        /// <summary>
        /// The categories associated with the appointment.
        /// </summary>
        [ImportParameter(nameof(Categories))]
        public IEnumerable<string> Categories { get; set; } = [];

        /// <summary>
        /// a value indicating whether the appointment was created by Exchange.
        /// </summary>
        [ImportParameter(nameof(CreatedByExchange))]
        public bool CreatedByExchange { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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