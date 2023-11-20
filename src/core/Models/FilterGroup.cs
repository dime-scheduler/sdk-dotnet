using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Models
{
    public class FilterGroup : IImportRequestable, IValidatableImportRequest<FilterGroup>
    {
        [ImportParameter(nameof(Id), TransactionType.Append)]
        public int Id { get; set; }

        [ImportParameter("GroupName", TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [ImportParameter(nameof(ColumnNo), TransactionType.Append)]
        public int ColumnNo { get; set; }

        [ImportParameter(nameof(DataFilter), TransactionType.Append)]
        public bool DataFilter { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<FilterGroup>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<FilterGroup>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.FilterGroup.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.FilterGroup.Delete, this.CreateParameters(TransactionType.Delete));

        FilterGroup IValidatableImportRequest<FilterGroup>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<FilterGroup>(validationContext);
    }
}