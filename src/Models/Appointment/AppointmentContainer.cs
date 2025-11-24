using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class AppointmentContainer : IAppointmentIdentifier, IImportEntity, IValidatableImportRequest<AppointmentContainer>
    {
        /// <summary>
        /// the container name.
        /// </summary>
        [Description("The container name.")]
        [ImportParameter(nameof(Container))]
        [Required]
        [MaxLength(100)]
        public string Container { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentNo/*'/>
        [Description("The external identifier for this appointment.")]
        public string AppointmentNo { get; set; }

        /// <summary>
        /// the appointment GUID.
        /// </summary>
        [Description("The appointment GUID.")]
        [ImportParameter(nameof(Appointment))]
        [Required]
        public Guid Appointment { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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