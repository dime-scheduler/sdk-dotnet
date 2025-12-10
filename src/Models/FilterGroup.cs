using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class FilterGroup : IImportEntity, IValidatableImportRequest<FilterGroup>
    {
        public FilterGroup()
        {
        }

        public FilterGroup(string name)
        {
            Name = name;
        }

        /// <summary>
        /// the filter group identifier.
        /// </summary>
        [Description("The filter group identifier.")]
        [ImportParameter(nameof(Id), TransactionType.Append)]
        public int Id { get; set; }

        /// <summary>
        /// the name of the filter group.
        /// </summary>
        [Description("The name of the filter group.")]
        [ImportParameter("GroupName", TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// the column number.
        /// </summary>
        [Description("The column number.")]
        [ImportParameter(nameof(ColumnNo), TransactionType.Append)]
        public int ColumnNo { get; set; }

        /// <summary>
        /// Indicates whether this is a data filter.
        /// </summary>
        [Description("Indicates whether this is a data filter.")]
        [ImportParameter(nameof(DataFilter), TransactionType.Append)]
        public bool DataFilter { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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