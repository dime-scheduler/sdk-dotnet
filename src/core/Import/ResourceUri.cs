namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceUri : IImportRequestable
    {
        [ImportParameter(nameof(ResourceNo))]
        public string ResourceNo { get; set; }

        [ImportParameter("Url")]
        public string Uri { get; set; }

        [ImportParameter("UrlDesc")]
        public string Description { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => new(ImportProcedures.Resource.Uri.Append, this.CreateParameters(TransactionType.Append));
    }
}