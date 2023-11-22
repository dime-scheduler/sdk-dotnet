using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Models
{
    public class Connector : IImportRequestable, IValidatableImportRequest<Connector>
    {
        public Connector()
        {
        }

        [ImportParameter(nameof(Name))]
        [RequiredIf(TransactionType.Append)]
        public string Name { get; set; }

        [ImportParameter(nameof(Description))]
        public string Description { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp))]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType))]
        [MaxLength(10)]
        public string SourceType { get; set; }

        [ImportParameter(nameof(SendAppointmentToWebService))]
        public bool SendAppointmentToWebService { get; set; } = true;

        [ImportParameter("WebServiceAddress")]
        public string Uri { get; set; }

        [ImportParameter(nameof(BackOfficeSystem))]
        public string BackOfficeSystem { get; set; }

        [ImportParameter(nameof(Login))]
        public string Login { get; set; }

        [ImportParameter(nameof(BackOfficeSystem))]
        public string Password { get; set; }

        /// <summary>
        /// A comma-separated list that accepts either of these values: "Create", "Update", "Delete"
        /// </summary>        
        public string CrudTypes { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Connector>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Connector>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Connector.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Connector.Delete, this.CreateParameters(TransactionType.Delete));

        Connector IValidatableImportRequest<Connector>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Connector>(validationContext);
    }
}