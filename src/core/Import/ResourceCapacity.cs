using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceCapacity : IImportRequestable, IValidatableImportRequest<ResourceCapacity>
    {        
        [ImportParameter(nameof(ResourceNo))]
        [Required]
        [MaxLength(50)]
        public string ResourceNo { get; set; }

        [ImportParameter("CapacityDate")]
        public DateTime Date { get; set; }

        [ImportParameter(nameof(CapacityInSeconds))]
        public long? CapacityInSeconds { get; set; }

        [ImportParameter("CapacityQty")]
        public decimal? Quantity { get; set; }

        [ImportParameter("CapacityUOM")]
        [MaxLength(20)]
        public string UnitOfMeasure { get; set; }

        [ImportParameter("CapacityUOMConversion")]
        public decimal? UnitOfMeasureConversion { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<ResourceCapacity>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<ResourceCapacity>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Resource.Capacity.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Resource.Capacity.Delete, this.CreateParameters(TransactionType.Delete));

        ResourceCapacity IValidatableImportRequest<ResourceCapacity>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<ResourceCapacity>(validationContext);
    }
}