using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Appointment : IAppointmentIdentifier, IImportEntity, IValidatableImportRequest<Appointment>
    {
        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentNo/*'/>
        public string AppointmentNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentId/*'/>
        [ImportParameter(nameof(AppointmentId), TransactionType.Append, TransactionType.Delete)]
        [RequiredIf(TransactionType.Delete)]
        public long? AppointmentId { get; set; }

        [ImportParameter(nameof(AppointmentGuid), TransactionType.Append, TransactionType.Delete)]
        public Guid? AppointmentGuid { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp), TransactionType.Append, TransactionType.Delete)]
        [MaxLength(30)]
        [RequiredIf(TransactionType.Append)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType), TransactionType.Append, TransactionType.Delete)]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/JobNo/*'/>
        [ImportParameter(nameof(JobNo), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string JobNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/Taskno/*'/>
        [ImportParameter(nameof(TaskNo), TransactionType.Append)]
        [MaxLength(50)]
        [RequiredIf(TransactionType.Append)]
        public string TaskNo { get; set; }

        /// <summary>
        /// Gets or sets the resource number.
        /// </summary>
        [ImportParameter(nameof(ResourceNo), TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        [RequiredIf(TransactionType.Append)]
        public string ResourceNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Subject/*'/>
        [ImportParameter(nameof(Subject), TransactionType.Append)]
        public string Subject { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Body/*'/>
        [ImportParameter(nameof(Body), TransactionType.Append)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the start date and time of the appointment.
        /// </summary>
        [ImportParameter(nameof(Start), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        public DateTime? Start { get; set; }

        /// <summary>
        /// Gets or sets the end date and time of the appointment.
        /// </summary>
        [ImportParameter(nameof(End), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        public DateTime? End { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is an all-day event.
        /// </summary>
        [ImportParameter("IsAllDayEvent", TransactionType.Append)]
        public bool? IsAllDay { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/TimeMarker/*'/>
        [ImportParameter(nameof(TimeMarker), TransactionType.Append)]
        public string TimeMarker { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Category/*'/>
        [ImportParameter(nameof(Category), TransactionType.Append)]
        public string Category { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Importance/*'/>
        [ImportParameter(nameof(Importance), TransactionType.Append)]
        public Importance? Importance { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Locked/*'/>
        [ImportParameter(nameof(Locked), TransactionType.Append)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to replace the resource.
        /// </summary>
        [ImportParameter(nameof(ReplaceResource), TransactionType.Append)]
        public bool? ReplaceResource { get; set; }

        /// <summary>
        /// Gets or sets the back office identifier.
        /// </summary>
        [ImportParameter("BackofficeID", TransactionType.Append)]
        [MaxLength(100)]
        public string BackOfficeId { get; set; }

        /// <summary>
        /// Gets or sets the back office parent identifier.
        /// </summary>
        [ImportParameter("BackofficeParentID", TransactionType.Append)]
        [MaxLength(100)]
        public string BackOfficeParentId { get; set; }

        /// <summary>
        /// Gets or sets the planning unit of measure.
        /// </summary>
        [ImportParameter("PlanningUOM", TransactionType.Append)]
        [MaxLength(20)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Gets or sets the planning unit of measure conversion factor.
        /// </summary>
        [ImportParameter("PlanningUOMConversion", TransactionType.Append)]
        public decimal? UnitOfMeasureConversion { get; set; }

        /// <summary>
        /// Gets or sets the planning quantity.
        /// </summary>
        [ImportParameter("PlanningQty", TransactionType.Append)]
        public decimal? PlanningQuantity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use fixed planning quantity.
        /// </summary>
        [ImportParameter("UseFixPlanningQty", TransactionType.Append)]
        public bool? UseFixedPlanningQuantity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to round to unit of measure.
        /// </summary>
        [ImportParameter("RoundToUOM", TransactionType.Append)]
        public bool? RoundToUnitOfMeasure { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/SentFromBackOffice/*'/>
        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool? SentFromBackOffice { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this is a manual appointment.
        /// </summary>
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