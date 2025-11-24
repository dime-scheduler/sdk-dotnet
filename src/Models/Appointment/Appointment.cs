using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Appointment : IAppointmentIdentifier, IImportEntity, IValidatableImportRequest<Appointment>
    {
        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentNo/*'/>
        [Description("The external identifier for this appointment.")]
        public string AppointmentNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentId/*'/>
        [Description("The internal appointment id. Do not rely on its existence. Use AppointmentNo instead.")]
        [ImportParameter(nameof(AppointmentId), TransactionType.Append, TransactionType.Delete)]
        [RequiredIf(TransactionType.Delete)]
        public long? AppointmentId { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentGuid/*'/>
        [Description("The identifier for this appointment.")]
        [ImportParameter(nameof(AppointmentGuid), TransactionType.Append, TransactionType.Delete)]
        public Guid? AppointmentGuid { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [Description("Identifies the record's originating system.")]
        [ImportParameter(nameof(SourceApp), TransactionType.Append, TransactionType.Delete)]
        [MaxLength(30)]
        [RequiredIf(TransactionType.Append)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [Description("Identifies the record's type in the originating system.")]
        [ImportParameter(nameof(SourceType), TransactionType.Append, TransactionType.Delete)]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/JobNo/*'/>
        [Description("Identifies the job.")]
        [ImportParameter(nameof(JobNo), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string JobNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/Taskno/*'/>
        [Description("Identifies the task.")]
        [ImportParameter(nameof(TaskNo), TransactionType.Append)]
        [MaxLength(50)]
        [RequiredIf(TransactionType.Append)]
        public string TaskNo { get; set; }

        /// <summary>
        /// The resource number.
        /// </summary>
        [Description("the resource number.")]
        [ImportParameter(nameof(ResourceNo), TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        [RequiredIf(TransactionType.Append)]
        public string ResourceNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Subject/*'/>
        [Description("the subject.")]
        [ImportParameter(nameof(Subject), TransactionType.Append)]
        public string Subject { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Body/*'/>
        [Description("the body content.")]
        [ImportParameter(nameof(Body), TransactionType.Append)]
        public string Body { get; set; }

        /// <summary>
        /// The start date and time of the appointment.
        /// </summary>
        [Description("the start date and time of the appointment.")]
        [ImportParameter(nameof(Start), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        public DateTime? Start { get; set; }

        /// <summary>
        /// The end date and time of the appointment.
        /// </summary>
        [Description("the end date and time of the appointment.")]
        [ImportParameter(nameof(End), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        public DateTime? End { get; set; }

        /// <summary>
        /// Indicates whether this is an all-day event.
        /// </summary>
        [Description("Indicates whether this is an all-day event.")]
        [ImportParameter("IsAllDayEvent", TransactionType.Append)]
        public bool? IsAllDay { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/TimeMarker/*'/>
        [Description("the time marker.")]
        [ImportParameter(nameof(TimeMarker), TransactionType.Append)]
        public string TimeMarker { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Category/*'/>
        [Description("the category.")]
        [ImportParameter(nameof(Category), TransactionType.Append)]
        public string Category { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Importance/*'/>
        [Description("the importance level.")]
        [ImportParameter(nameof(Importance), TransactionType.Append)]
        public Importance? Importance { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Locked/*'/>
        [Description("Indicates whether the item is locked.")]
        [ImportParameter(nameof(Locked), TransactionType.Append)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Indicates whether to replace the resource.
        /// </summary>
        [Description("Indicates whether to replace the resource.")]
        [ImportParameter(nameof(ReplaceResource), TransactionType.Append)]
        public bool? ReplaceResource { get; set; }

        /// <summary>
        /// The back office identifier.
        /// </summary>
        [Description("the back office identifier.")]
        [ImportParameter("BackofficeID", TransactionType.Append)]
        [MaxLength(100)]
        public string BackOfficeId { get; set; }

        /// <summary>
        /// The back office parent identifier.
        /// </summary>
        [Description("the back office parent identifier.")]
        [ImportParameter("BackofficeParentID", TransactionType.Append)]
        [MaxLength(100)]
        public string BackOfficeParentId { get; set; }

        /// <summary>
        /// The planning unit of measure.
        /// </summary>
        [Description("the planning unit of measure.")]
        [ImportParameter("PlanningUOM", TransactionType.Append)]
        [MaxLength(20)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// The planning unit of measure conversion factor.
        /// </summary>
        [Description("the planning unit of measure conversion factor.")]
        [ImportParameter("PlanningUOMConversion", TransactionType.Append)]
        public decimal? UnitOfMeasureConversion { get; set; }

        /// <summary>
        /// The planning quantity.
        /// </summary>
        [Description("the planning quantity.")]
        [ImportParameter("PlanningQty", TransactionType.Append)]
        public decimal? PlanningQuantity { get; set; }

        /// <summary>
        /// Indicates whether to use fixed planning quantity.
        /// </summary>
        [Description("Indicates whether to use fixed planning quantity.")]
        [ImportParameter("UseFixPlanningQty", TransactionType.Append)]
        public bool? UseFixedPlanningQuantity { get; set; }

        /// <summary>
        /// Indicates whether to round to unit of measure.
        /// </summary>
        [Description("Indicates whether to round to unit of measure.")]
        [ImportParameter("RoundToUOM", TransactionType.Append)]
        public bool? RoundToUnitOfMeasure { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/SentFromBackOffice/*'/>
        [Description("Indicates whether the request was sent from back office.")]
        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool? SentFromBackOffice { get; set; } = true;

        /// <summary>
        /// Indicates whether this is a manual appointment.
        /// </summary>
        [Description("Indicates whether this is a manual appointment.")]
        [ImportParameter(nameof(IsManualAppointment), TransactionType.Append)]
        public bool? IsManualAppointment { get; set; } = false;

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Appointment>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Appointment>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Appointment.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Appointment.Delete, this.CreateParameters(TransactionType.Delete));

        Appointment IValidatableImportRequest<Appointment>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Appointment>(validationContext);
    }
}