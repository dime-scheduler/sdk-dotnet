using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Models
{
    public class AppointmentContainer : IAppointmentIdentifier, IImportRequestable, IValidatableImportRequest<AppointmentContainer>
    {
        [ImportParameter(nameof(Container))]
        [Required]
        [MaxLength(100)]
        public string Container { get; set; }

        public string AppointmentNo { get; set; }

        [ImportParameter(nameof(Appointment))]
        [Required]
        [MaxLength(100)]
        public string Appointment { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<AppointmentContainer>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<AppointmentContainer>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.AppointmentContainer.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.AppointmentContainer.Delete, this.CreateParameters(TransactionType.Delete));

        AppointmentContainer IValidatableImportRequest<AppointmentContainer>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<AppointmentContainer>(validationContext);
    }
}