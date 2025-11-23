using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class AppointmentImportance : IAppointmentIdentifier, IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp))]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType))]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentNo/*'/>
        public string AppointmentNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentId/*'/>
        [ImportParameter(nameof(AppointmentId))]
        public long? AppointmentId { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Importance/*'/>
        [ImportParameter(nameof(Importance))]
        public Importance Importance { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentGuid/*'/>
        [ImportParameter(nameof(AppointmentGuid))]
        public Guid? AppointmentGuid { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/SentFromBackOffice/*'/>
        [ImportParameter(nameof(SentFromBackOffice))]
        public bool SentFromBackOffice { get; set; } = true;

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(
                ImportProcedures.Appointment.Importance.Append,
                this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException("Action does not exist yet in Dime.Scheduler");
    }
}