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
            Color = color;
        }

        [Required]
        [ImportParameter("CategoryName")]
        public string Name { get; set; }

        [Required]
        [ImportParameter(nameof(DisplayName), TransactionType.Append)]
        public string DisplayName { get; set; }

        [ImportParameter("CategoryHexColor", TransactionType.Append)]
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
            => new(ImportProcedures.Category.Delete, this.CreateParameters(TransactionType.Append));

        Category IValidatableImportRequest<Category>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Pin>(validationContext);
    }
}