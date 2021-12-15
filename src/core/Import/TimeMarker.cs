using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class TimeMarker : IImportRequestable, IValidatableImportRequest<TimeMarker>
    {
        public TimeMarker()
        {
        }

        public TimeMarker(string name, string color)
        {
            Name = name;
            Color = color;
        }

        /// <include file='docs.xml' path='docs/members[@name="Indicator"]/Name/*'/>
        [ImportParameter("TimeMarker")]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Indicator"]/Color/*'/>
        [ImportParameter("HexColor", TransactionType.Append)]
        [MaxLength(7)]
        public string Color { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<TimeMarker>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<TimeMarker>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.TimeMarker.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.TimeMarker.Delete, this.CreateParameters(TransactionType.Delete));

        TimeMarker IValidatableImportRequest<TimeMarker>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<TimeMarker>(validationContext);
    }
}