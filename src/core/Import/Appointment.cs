using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Appointment : IImportRequestable, IValidatableImportRequest<Appointment>
    {
        [ImportParameter(nameof(AppointmentId), TransactionType.Append)]
        [RequiredIf(TransactionType.Delete)]
        public long? AppointmentId { get; set; }

        [ImportParameter(nameof(AppointmentGuid), TransactionType.Append)]
        public Guid? AppointmentGuid { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp), TransactionType.Append, TransactionType.Delete)]
        [MaxLength(30)]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType), TransactionType.Append, TransactionType.Delete)]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(10)]
        public string SourceType { get; set; }

        [ImportParameter(nameof(JobNo), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string JobNo { get; set; }

        [ImportParameter(nameof(TaskNo), TransactionType.Append)]
        [MaxLength(50)]
        [RequiredIf(TransactionType.Append)]
        public string TaskNo { get; set; }

        [ImportParameter(nameof(ResourceNo), TransactionType.Append)]
        [MaxLength(50)]
        [RequiredIf(TransactionType.Append)]
        public string ResourceNo { get; set; }

        [ImportParameter(nameof(Subject), TransactionType.Append)]
        public string Subject { get; set; }

        [ImportParameter(nameof(Body), TransactionType.Append)]
        public string Body { get; set; }

        [ImportParameter(nameof(Start), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        public DateTime? Start { get; set; }

        [ImportParameter(nameof(End), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        public DateTime? End { get; set; }

        [ImportParameter("IsAllDayEvent", TransactionType.Append)]
        public bool? IsAllDay { get; set; }

        [ImportParameter(nameof(TimeMarker), TransactionType.Append)]
        public string TimeMarker { get; set; }

        [ImportParameter(nameof(Category), TransactionType.Append)]
        public string Category { get; set; }

        [ImportParameter(nameof(Importance), TransactionType.Append)]
        public Importance? Importance { get; set; }

        [ImportParameter(nameof(Locked), TransactionType.Append)]
        public bool? Locked { get; set; }

        [ImportParameter(nameof(ReplaceResource), TransactionType.Append)]
        public bool? ReplaceResource { get; set; }

        [ImportParameter("BackofficeID", TransactionType.Append)]
        [MaxLength(100)]
        public string BackOfficeId { get; set; }

        [ImportParameter("BackofficeParentID", TransactionType.Append)]
        [MaxLength(100)]
        public string BackOfficeParentId { get; set; }

        [ImportParameter("PlanningUOM", TransactionType.Append)]
        [MaxLength(20)]
        public string UnitOfMeasure { get; set; }

        [ImportParameter("PlanningUOMConversion", TransactionType.Append)]
        public decimal? UnitOfMeasureConversion { get; set; }

        [ImportParameter("PlanningQty", TransactionType.Append)]
        public decimal? PlanningQuantity { get; set; }

        [ImportParameter("UseFixPlanningQty", TransactionType.Append)]
        public bool? UseFixedPlanningQuantity { get; set; }

        [ImportParameter("RoundToUOM", TransactionType.Append)]
        public bool? RoundToUnitOfMeasure { get; set; }

        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool? SentFromBackOffice { get; set; } = true;

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
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