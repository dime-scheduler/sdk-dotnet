using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceCapacity : IImportRequestable, IValidatableImportRequest<ResourceCapacity>
    {
        [Required]
        public string ResourceNo { get; set; }

        public DateTime Date { get; set; }

        public int CapacityInSeconds { get; set; }

        public int Quantity { get; set; }

        public string UnitOfMeasure { get; set; }

        public decimal UnitOfMeasureConversion { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? ((IValidatableImportRequest<ResourceCapacity>)this).Validate(transactionType).CreateAppendRequest()
                : ((IValidatableImportRequest<ResourceCapacity>)this).Validate(transactionType).CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertResourceCapacity",
                new List<string> {
                    "ResourceNo",
                    "CapacityDate",
                    "CapacityInSeconds",
                    "CapacityQty",
                    "CapacityUOM",
                    "CapacityUOMConversion"
                }.ToArray(),
                new List<string>
                {
                   ResourceNo,
                   Date.ToString("s"),
                   CapacityInSeconds.ToString(),
                   Quantity.ToString(),
                   UnitOfMeasure,
                   UnitOfMeasureConversion.ToString()
                }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException();

        ResourceCapacity IValidatableImportRequest<ResourceCapacity>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<ResourceCapacity>(validationContext);
    }
}