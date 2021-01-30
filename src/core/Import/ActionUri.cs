using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class ActionUri : IImportRequestable
    {
        public string SourceApp { get; set; }
        public string SourceType { get; set; }
        public int UriType { get; set; }
        public string Uri { get; set; }
        public string Description { get; set; }
        public bool Default { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
         => new ImportRequest(
                "mboc_upsertActionUrl",
                new List<string> { "SourceApp", "SourceType", "UrlType", "Url", "UrlDesc", "DefaultUrl" }.ToArray(),
                new List<string> { SourceApp, SourceType, UriType.ToString(), Uri, Description, Default ? "1" : "0" }.ToArray());
    }
}