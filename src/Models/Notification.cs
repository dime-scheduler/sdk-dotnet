using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Notification : IImportEntity, IValidatableImportRequest<Notification>, IAppointmentIdentifier
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [Description("Identifies the record's originating system.")]
        [ImportParameter(nameof(SourceApp))]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [Description("Identifies the record's type in the originating system.")]
        [ImportParameter(nameof(SourceType))]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentId/*'/>
        [Description("The internal appointment id. Do not rely on its existence. Use AppointmentNo instead.")]
        [ImportParameter(nameof(AppointmentId))]
        public long? AppointmentId { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentNo/*'/>
        [Description("The external identifier for this appointment.")]
        public string AppointmentNo { get; set; }

        /// <summary>
        /// the connector identifier.
        /// </summary>
        [Description("The connector identifier.")]
        [MaxLength(50)]
        [ImportParameter("mboc_id")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// the notification type.
        /// </summary>
        [Description("The notification type.")]
        [ImportParameter("NotificationType", TransactionType.Append)]
        public NotificationType Type { get; set; }

        /// <summary>
        /// the notification code.
        /// </summary>
        [Description("The notification code.")]
        [MaxLength(20)]
        [ImportParameter("NotificationCode", TransactionType.Append)]
        public string Code { get; set; }

        /// <summary>
        /// the notification text.
        /// </summary>
        [Description("The notification text.")]
        [ImportParameter("NotificationText", TransactionType.Append)]
        public string Text { get; set; }

        /// <summary>
        /// the notification date and time.
        /// </summary>
        [Description("The notification date and time.")]
        [ImportParameter("NotificationDate", TransactionType.Append)]
        public DateTime? Date { get; set; } = DateTime.Now;

        /// <include file='docs.xml' path='docs/members[@name="Work"]/JobNo/*'/>
        [Description("Identifies the job.")]
        [ImportParameter(nameof(JobNo))]
        [MaxLength(50)]
        public string JobNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/Taskno/*'/>
        [Description("Identifies the task.")]
        [ImportParameter(nameof(TaskNo))]
        [MaxLength(50)]
        public string TaskNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentGuid/*'/>
        [Description("The identifier for this appointment.")]
        [ImportParameter(nameof(AppointmentGuid))]
        public Guid? AppointmentGuid { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/SentFromBackOffice/*'/>
        [Description("Indicates whether the request was sent from back office.")]
        [ImportParameter(nameof(SentFromBackOffice))]
        public bool SentFromBackOffice { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Notification>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Notification>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Notification.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Notification.Delete, this.CreateParameters(TransactionType.Delete));

        Notification IValidatableImportRequest<Notification>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Notification>(validationContext);
    }
}