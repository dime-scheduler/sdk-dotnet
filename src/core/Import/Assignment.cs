using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Assignment : IAppointmentIdentifier, IImportRequestable, IValidatableImportRequest<Assignment>
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp))]
        [Required]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType))]
        [Required]
        [MaxLength(10)]
        public string SourceType { get; set; }

        public string AppointmentNo { get; set; }

        [ImportParameter(nameof(AppointmentId))]
        [Required]
        public long AppointmentId { get; set; }

        [ImportParameter(nameof(AppointmentGuid))]
        public Guid? AppointmentGuid { get; set; }

        [ImportParameter(nameof(ResourceNo))]
        [Required]
        [MaxLength(50)]
        public string ResourceNo { get; set; }

        [ImportParameter(nameof(SentFromBackOffice))]
        public bool SentFromBackOffice { get; set; } = true;

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Assignment>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Assignment>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Assignment.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Assignment.Delete, this.CreateParameters(TransactionType.Delete));

        Assignment IValidatableImportRequest<Assignment>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Assignment>(validationContext);
    }
}