using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Connector : IImportEntity, IValidatableImportRequest<Connector>
    {
        public Connector()
        {
        }

        /// <summary>
        /// Gets or sets the name of the connector.
        /// </summary>
        [ImportParameter(nameof(Name))]
        [RequiredIf(TransactionType.Append)]
        public string Name { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Description/*'/>
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

        /// <summary>
        /// Gets or sets a value indicating whether appointments should be sent to the web service.
        /// </summary>
        [ImportParameter(nameof(SendAppointmentToWebService))]
        public bool SendAppointmentToWebService { get; set; } = true;

        /// <summary>
        /// Gets or sets the web service address URI.
        /// </summary>
        [ImportParameter("WebServiceAddress")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the CRUD operation types supported by this connector.
        /// </summary>
        public IEnumerable<Crud> CrudTypes { get; set; } = [Crud.Create, Crud.Update, Crud.Delete];

        /// <summary>
        /// Gets or sets the type of the connector.
        /// </summary>
        [ImportParameter(nameof(Type))]
        public ConnectorType? Type { get; set; } = ConnectorType.None;

        /// <summary>
        /// Gets or sets the authentication type for the connector.
        /// </summary>
        [ImportParameter("AuthType")]
        public ConnectorAuthType? AuthenticationType { get; set; } = ConnectorAuthType.None;

        /// <summary>
        /// Gets or sets the API type for the connector.
        /// </summary>
        [ImportParameter(nameof(ApiType))]
        public ConnectorApiType? ApiType { get; set; } = ConnectorApiType.SOAP;

        /// <summary>
        /// Gets or sets the login credentials for the connector.
        /// </summary>
        [ImportParameter(nameof(Login))]
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets the password credentials for the connector.
        /// </summary>
        [ImportParameter(nameof(Password))]
        public string Password { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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