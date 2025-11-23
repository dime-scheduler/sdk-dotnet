using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Dime.Scheduler.Entities
{
    public class ActionUri : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp))]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType))]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <summary>
        /// Gets or sets the URI type.
        /// </summary>
        [ImportParameter("UrlType")]
        [JsonConverter(typeof(IntEnumConverter<UriType>))]
        public UriType UriType { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Uri/*'/>
        [ImportParameter("Url")]
        [Required]
        public string Uri { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [ImportParameter("UrlDesc")]
        [MaxLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is the default URI.
        /// </summary>
        [ImportParameter("DefaultUrl")]
        public bool Default { get; set; }

        /// <summary>
        /// Gets or sets the HTTP request type.
        /// </summary>
        [ImportParameter(nameof(RequestType))]
        [JsonConverter(typeof(IntEnumConverter<HttpRequestType>))]
        public HttpRequestType RequestType { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.ActionUri.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException("Action does not exist yet in Dime.Scheduler");
    }
}