using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceFilterValue : IImportRequestable
    {
        public string SourceApp { get; set; }

        public string SourceType { get; set; }

        public string ResourceNo { get; set; }

        public string FilterGroup { get; set; }

        public string FilterValue { get; set; }

        public bool TransferToTemp { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => new ImportRequest(
                "mboc_upsertResourceFilterValue",
                new List<string> { "SourceApp", "SourceType", "ResourceNo", "FilterGroup", "FilterValue", "TransferToTemp" }.ToArray(),
                new List<string> { SourceApp, SourceType, ResourceNo, FilterGroup, FilterValue, TransferToTemp ? "1" : "0" }.ToArray());
    }
}