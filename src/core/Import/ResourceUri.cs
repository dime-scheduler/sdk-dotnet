namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceUri : IImportRequestable
    {
        public string ResourceNo { get; set; }
        public string Uri { get; set; }
        public string Description { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => new ImportRequest(
                "mboc_upsertResourceUrl",
                new ImportParameter("ResourceNo", ResourceNo),
                new ImportParameter("Url", Uri),
                new ImportParameter("UrlDesc", Description));
    }
}