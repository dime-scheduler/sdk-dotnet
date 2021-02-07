using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Appointment : IImportRequestable, IValidatableImportRequest<Appointment>
    {
        [RequiredIf(TransactionType.Delete)]
        [ImportParameter(nameof(AppointmentId), TransactionType.Append)]
        public long AppointmentId { get; set; }

        [ImportParameter(nameof(AppointmentGuid), TransactionType.Append)]
        public Guid AppointmentGuid { get; set; }

        [Required]
        [MaxLength(30)]
        [ImportParameter(nameof(SourceApp), TransactionType.Append, TransactionType.Delete)]
        public string SourceApp { get; set; }

        [Required]
        [MaxLength(10)]
        [ImportParameter(nameof(SourceType), TransactionType.Append, TransactionType.Delete)]
        public string SourceType { get; set; }

        [MaxLength(50)]
        [ImportParameter(nameof(JobNo), TransactionType.Append)]
        public string JobNo { get; set; }

        [MaxLength(50)]
        [ImportParameter(nameof(TaskNo), TransactionType.Append)]
        public string TaskNo { get; set; }

        [MaxLength(50)]
        [ImportParameter(nameof(ResourceNo), TransactionType.Append)]
        public string ResourceNo { get; set; }

        [ImportParameter(nameof(Subject), TransactionType.Append)]
        public string Subject { get; set; }

        [ImportParameter(nameof(Body), TransactionType.Append)]
        public string Body { get; set; }

        [RequiredIf(TransactionType.Append)]
        [ImportParameter(nameof(Start), TransactionType.Append)]
        public DateTime? Start { get; set; }

        [RequiredIf(TransactionType.Append)]
        [ImportParameter(nameof(End), TransactionType.Append)]
        public DateTime? End { get; set; }

        [ImportParameter("IsAllDayEvent", TransactionType.Append)]
        public bool? IsAllDay { get; set; }

        [ImportParameter(nameof(TimeMarker), TransactionType.Append)]
        public string TimeMarker { get; set; }

        [ImportParameter(nameof(Category), TransactionType.Append)]
        public string Category { get; set; }

        [ImportParameter(nameof(Importance), TransactionType.Append)]
        public int? Importance { get; set; }

        [ImportParameter(nameof(Locked), TransactionType.Append)]
        public bool? Locked { get; set; }

        [ImportParameter(nameof(ReplaceResource), TransactionType.Append)]
        public bool? ReplaceResource { get; set; }

        [ImportParameter(nameof(BackOfficeId), TransactionType.Append)]
        public string BackOfficeId { get; set; }

        [ImportParameter(nameof(BackOfficeParentId), TransactionType.Append)]
        public string BackOfficeParentId { get; set; }

        [ImportParameter(nameof(UnitOfMeasure), TransactionType.Append)]
        public string UnitOfMeasure { get; set; }

        [ImportParameter("PlanningUOMConversion", TransactionType.Append)]
        public decimal? UnitOfMeasureConversion { get; set; }

        [ImportParameter(nameof(PlanningQuantity), TransactionType.Append)]
        public decimal? PlanningQuantity { get; set; }

        [ImportParameter(nameof(UseFixedPlanningQuantity), TransactionType.Append)]
        public bool? UseFixedPlanningQuantity { get; set; }

        [ImportParameter("RoundToUOM", TransactionType.Append)]
        public bool? RoundToUnitOfMeasure { get; set; }

        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool? SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Appointment>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Appointment>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(ImportProcedures.Appointment.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(ImportProcedures.Appointment.Delete, this.CreateParameters(TransactionType.Delete));

        Appointment IValidatableImportRequest<Appointment>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Appointment>(validationContext);
    }
}