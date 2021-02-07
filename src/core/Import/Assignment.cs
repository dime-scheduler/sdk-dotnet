using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Assignment : IImportRequestable, IValidatableImportRequest<Assignment>
    {
        [Required]
        [MaxLength(30)]
        [ImportParameter(nameof(SourceApp))]
        public string SourceApp { get; set; }

        [Required]
        [MaxLength(10)]
        [ImportParameter(nameof(SourceType))]
        public string SourceType { get; set; }

        [Required]
        [MaxLength(50)]
        [ImportParameter(nameof(AppointmentId))]
        public long AppointmentId { get; set; }

        [ImportParameter(nameof(AppointmentGuid))]
        public string AppointmentGuid { get; set; }

        [Required]
        [MaxLength(50)]
        [ImportParameter(nameof(ResourceNo))]
        public string ResourceNo { get; set; }

        [ImportParameter(nameof(SentFromBackOffice))]
        public long? SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Assignment>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Assignment>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(ImportProcedures.Assignment.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(ImportProcedures.Assignment.Delete, this.CreateParameters(TransactionType.Delete));

        Assignment IValidatableImportRequest<Assignment>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Assignment>(validationContext);
    }
}