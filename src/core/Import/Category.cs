using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Category : IImportRequestable, IValidatableImportRequest<Category>
    {
        public Category()
        {
        }

        public Category(string name, string color)
        {
            Name = name;
            DisplayName = name;
            Color = color;
        }

        /// <include file='docs.xml' path='docs/members[@name="Indicator"]/Name/*'/>
        [ImportParameter("CategoryName")]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Indicator"]/Name/*'/>
        [ImportParameter(nameof(DisplayName), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(100)]
        public string DisplayName { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Indicator"]/Color/*'/>
        [RequiredIf(TransactionType.Append)]
        [ImportParameter("CategoryHexColor", TransactionType.Append)]
        [MaxLength(7)]
        public string Color { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
                => transactionType switch
                {
                    TransactionType.Append => ((IValidatableImportRequest<Category>)this).Validate(transactionType).CreateAppendRequest(),
                    TransactionType.Delete => ((IValidatableImportRequest<Category>)this).Validate(transactionType).CreateDeleteRequest(),
                    _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
                };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Category.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Category.Delete, this.CreateParameters(TransactionType.Delete));

        Category IValidatableImportRequest<Category>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Category>(validationContext);
    }
}