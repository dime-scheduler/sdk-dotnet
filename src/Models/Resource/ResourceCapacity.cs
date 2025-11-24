using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class ResourceCapacity : IImportEntity, IValidatableImportRequest<ResourceCapacity>
    {
        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [Description("The resource number.")]
        [ImportParameter(nameof(ResourceNo))]
        [Required]
        [MaxLength(50)]
        public string ResourceNo { get; set; }

        /// <summary>
        /// the capacity date.
        /// </summary>
        [Description("The capacity date.")]
        [ImportParameter("CapacityDate")]
        public DateTime Date { get; set; }

        /// <summary>
        /// the capacity in seconds.
        /// </summary>
        [Description("The capacity in seconds.")]
        [ImportParameter(nameof(CapacityInSeconds))]
        public long? CapacityInSeconds { get; set; }

        /// <summary>
        /// the capacity quantity.
        /// </summary>
        [Description("The capacity quantity.")]
        [ImportParameter("CapacityQty")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// the unit of measure.
        /// </summary>
        [Description("The unit of measure.")]
        [ImportParameter("CapacityUOM")]
        [MaxLength(20)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// the unit of measure conversion factor.
        /// </summary>
        [Description("The unit of measure conversion factor.")]
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