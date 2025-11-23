using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class ResourceCapacity : IImportEntity, IValidatableImportRequest<ResourceCapacity>
    {
        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [ImportParameter(nameof(ResourceNo))]
        [Required]
        [MaxLength(50)]
        public string ResourceNo { get; set; }

        /// <summary>
        /// Gets or sets the capacity date.
        /// </summary>
        [ImportParameter("CapacityDate")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the capacity in seconds.
        /// </summary>
        [ImportParameter(nameof(CapacityInSeconds))]
        public long? CapacityInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the capacity quantity.
        /// </summary>
        [ImportParameter("CapacityQty")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit of measure.
        /// </summary>
        [ImportParameter("CapacityUOM")]
        [MaxLength(20)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Gets or sets the unit of measure conversion factor.
        /// </summary>
        [ImportParameter("CapacityUOMConversion")]
        public decimal? UnitOfMeasureConversion { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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