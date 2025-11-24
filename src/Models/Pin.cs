using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Pin : Indicator, IImportEntity, IValidatableImportRequest<Pin>
    {
        public Pin()
        {
        }

        public Pin(string name, string color)
        {
            Name = name;
            Color = color;
        }

        /// <include file='docs.xml' path='docs/members[@name="Indicator"]/Name/*'/>
        [Description("Identifies the indicator.")]
        [ImportParameter(nameof(Name))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(100)]
        public virtual string Name { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Indicator"]/Color/*'/>
        [Description("The hex color.")]
        [ImportParameter("HexColor", TransactionType.Append)]
        [MaxLength(7)]
        public virtual string Color { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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