using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class ResourceUri : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [Description("The resource number.")]
        [ImportParameter(nameof(ResourceNo))]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string ResourceNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Uri/*'/>
        [Description("The URI.")]
        [ImportParameter("Url")]
        [MaxLength(1000)]
        public string Uri { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [Description("The description of the URI.")]
        [ImportParameter("UrlDesc")]
        [MaxLength(255)]
        public string Description { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => new(ImportProcedures.Resource.Uri.Append, this.CreateParameters(TransactionType.Append));
    }
}