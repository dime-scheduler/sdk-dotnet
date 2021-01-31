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
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertResourceFilterValue",
                new List<string> { "SourceApp", "SourceType", "ResourceNo", "FilterGroup", "FilterValue", "TransferToTemp" }.ToArray(),
                new List<string> { SourceApp, SourceType, ResourceNo, FilterGroup, FilterValue, TransferToTemp.ToBit().ToString() }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deleteResourceCertificate",
                new List<string> { "SourceApp", "SourceType", "ResourceNo", "FilterGroup", "FilterValue" }.ToArray(),
                new List<string> { SourceApp, SourceType, ResourceNo, FilterGroup, FilterValue, }.ToArray());
    }
}