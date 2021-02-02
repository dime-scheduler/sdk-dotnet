using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
 public class FilterGroup : IImportRequestable, IValidatableImportRequest<FilterGroup>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int ColumnNo { get; set; }

        public bool DataFilter { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? ((IValidatableImportRequest<FilterGroup>)this).Validate(transactionType).CreateAppendRequest()
                : ((IValidatableImportRequest<FilterGroup>)this).Validate(transactionType).CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertFilterGroup",
                ("Id", Id.ToString()),
                ("GroupName", Name),
                ("ColumnNo", ColumnNo.ToString()),
                ("DataFilter", DataFilter.ToBit().ToString()));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest("mboc_deleteFilterGroup", ("GroupName", Name));

        FilterGroup IValidatableImportRequest<FilterGroup>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<FilterGroup>(validationContext);
    }
}