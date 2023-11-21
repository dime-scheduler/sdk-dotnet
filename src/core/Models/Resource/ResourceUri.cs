using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Models
{
    public class ResourceUri : IImportRequestable
    {
        [ImportParameter(nameof(ResourceNo))]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string ResourceNo { get; set; }

        [ImportParameter("Url")]
        [MaxLength(1000)]
        public string Uri { get; set; }

        [ImportParameter("UrlDesc")]
        [MaxLength(255)]
        public string Description { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => new(ImportProcedures.Resource.Uri.Append, this.CreateParameters(TransactionType.Append));
    }
}