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
        /// the name of the connector.
        /// </summary>
        [Description("The name of the connector.")]
        [ImportParameter(nameof(Name))]
        [RequiredIf(TransactionType.Append)]
        public string Name { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Description/*'/>
        [Description("The description.")]
        [ImportParameter(nameof(Description))]
        public string Description { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [Description("Identifies the record's originating system.")]
        [ImportParameter(nameof(SourceApp))]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [Description("Identifies the record's type in the originating system.")]
        [ImportParameter(nameof(SourceType))]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <summary>
        /// Indicates whether appointments should be sent to the web service.
        /// </summary>
        [Description("Indicates whether appointments should be sent to the web service.")]
        [ImportParameter(nameof(SendAppointmentToWebService))]
        public bool SendAppointmentToWebService { get; set; } = true;

        /// <summary>
        /// the web service address URI.
        /// </summary>
        [Description("The web service address URI.")]
        [ImportParameter("WebServiceAddress")]
        public string Uri { get; set; }

        /// <summary>
        /// the CRUD operation types supported by this connector.
        /// </summary>
        [Description("The CRUD operation types supported by this connector.")]
        public IEnumerable<Crud> CrudTypes { get; set; } = [Crud.Create, Crud.Update, Crud.Delete];

        /// <summary>
        /// the type of the connector.
        /// </summary>
        [Description("The type of the connector.")]
        [ImportParameter(nameof(Type))]
        public ConnectorType? Type { get; set; } = ConnectorType.None;

        /// <summary>
        /// the authentication type for the connector.
        /// </summary>
        [Description("The authentication type for the connector.")]
        [ImportParameter("AuthType")]
        public ConnectorAuthType? AuthenticationType { get; set; } = ConnectorAuthType.None;

        /// <summary>
        /// the API type for the connector.
        /// </summary>
        [Description("The API type for the connector.")]
        [ImportParameter(nameof(ApiType))]
        public ConnectorApiType? ApiType { get; set; } = ConnectorApiType.SOAP;

        /// <summary>
        /// the login credentials for the connector.
        /// </summary>
        [Description("The login credentials for the connector.")]
        [ImportParameter(nameof(Login))]
        public string Login { get; set; }

        /// <summary>
        /// the password credentials for the connector.
        /// </summary>
        [Description("The password credentials for the connector.")]
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