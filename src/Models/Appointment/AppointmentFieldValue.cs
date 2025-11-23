using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class AppointmentFieldValue : IAppointmentIdentifier, IImportEntity
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

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentGuid/*'/>
        [ImportParameter(nameof(AppointmentGuid))]
        public Guid? AppointmentGuid { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentId/*'/>
        [ImportParameter(nameof(AppointmentId))]
        public long? AppointmentId { get; set; }

        /// <summary>
        /// Gets or sets the field code.
        /// </summary>
        [ImportParameter(nameof(FieldCode))]
        [MaxLength(100)]
        [Required]
        public string FieldCode { get; set; }

        /// <summary>
        /// Gets or sets the field value.
        /// </summary>
        [ImportParameter(nameof(FieldValue))]
        [Required]
        public string FieldValue { get; set; }

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
            => new(ImportProcedures.Appointment.FieldValue.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException("Action does not exist in Dime.Scheduler");
    }
}