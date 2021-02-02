﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Dime.Scheduler.Sdk.Import
{
    public class FilterGroup : IImportRequestable, IValidatableImportRequest<FilterGroup>
    {
        [ImportParameter(nameof(Id), TransactionType.Append)]
        public int Id { get; set; }

        [Required]
        [ImportParameter("GroupName", TransactionType.Append, TransactionType.Delete)]
        public string Name { get; set; }

        [ImportParameter(nameof(ColumnNo), TransactionType.Append)]
        public int ColumnNo { get; set; }

        [ImportParameter(nameof(DataFilter), TransactionType.Append)]
        public bool DataFilter { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? ((IValidatableImportRequest<FilterGroup>)this).Validate(transactionType).CreateAppendRequest()
                : ((IValidatableImportRequest<FilterGroup>)this).Validate(transactionType).CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertFilterGroup",
                this.CreateParameterCollection<FilterGroup>(TransactionType.Append).ToArray());

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deleteFilterGroup",
                this.CreateParameterCollection<FilterGroup>(TransactionType.Delete).ToArray());

        FilterGroup IValidatableImportRequest<FilterGroup>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<FilterGroup>(validationContext);
    }
}