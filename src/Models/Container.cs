using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Container : IImportEntity, IValidatableImportRequest<Container>
    {
        /// <summary>
        /// the name of the container.
        /// </summary>
        [Description("The name of the container.")]
        [ImportParameter(nameof(Name))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// the handle date.
        /// </summary>
        [Description("The handle date.")]
        [ImportParameter(nameof(HandleDate), TransactionType.Append)]
        public DateTime? HandleDate { get; set; }

        /// <summary>
        /// Indicates whether the container is locked.
        /// </summary>
        [Description("Indicates whether the container is locked.")]
        [ImportParameter(nameof(HandleLocked), TransactionType.Append)]
        public bool HandleLocked { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Container>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Container>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Container.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Container.Delete, this.CreateParameters(TransactionType.Delete));

        Container IValidatableImportRequest<Container>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Container>(validationContext);
    }
}