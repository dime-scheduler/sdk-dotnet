namespace Dime.Scheduler.Sdk.Import
{
    public class ActionUri : IImportRequestable
    {
        [ImportParameter(nameof(SourceApp))]
        public string SourceApp { get; set; }

        [ImportParameter(nameof(SourceType))]
        public string SourceType { get; set; }

        [ImportParameter(nameof(UriType))]
        public int UriType { get; set; }

        [ImportParameter(nameof(Uri))]
        public string Uri { get; set; }

        [ImportParameter(nameof(Description))]
        public string Description { get; set; }

        [ImportParameter(nameof(Default))]
        public bool Default { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
         => new ImportRequest(ImportProcedures.ActionUri.Append, this.CreateParameters(transactionType));
    }
}