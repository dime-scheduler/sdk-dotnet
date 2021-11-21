using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Pin : IImportRequestable, IValidatableImportRequest<Pin>
    {
        public Pin()
        {

        }
        public Pin(string name, string color)
        {
            Name = name;
            Color = color;
        }
        
        [ImportParameter(nameof(Name))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(100)]
        public string Name { get; set; }

        [ImportParameter("HexColor", TransactionType.Append)]
        [MaxLength(7)]
        public string Color { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Pin>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Pin>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Pin.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Pin.Delete, this.CreateParameters(TransactionType.Delete));
        
        Pin IValidatableImportRequest<Pin>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Pin>(validationContext);
    }
}