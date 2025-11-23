using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class ResourceUri : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [ImportParameter(nameof(ResourceNo))]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string ResourceNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Uri/*'/>
        [ImportParameter("Url")]
        [MaxLength(1000)]
        public string Uri { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [ImportParameter("UrlDesc")]
        [MaxLength(255)]
        public string Description { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => new(ImportProcedures.Resource.Uri.Append, this.CreateParameters(TransactionType.Append));
    }
}