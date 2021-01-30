using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskFilterValue : IImportRequestable
    {
        public string SourceApp { get; set; }

        public string SourceType { get; set; }

        public string JobNo { get; set; }

        public string TaskNo { get; set; }

        public string FilterGroup { get; set; }

        public string FilterValue { get; set; }

        public bool TransferToTemp { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertTaskFilterValue",
                new List<string> {
                    "SourceApp",
                    "SourceType",
                    "JobNo",
                    "TaskNo",
                    "FilterGroup",
                    "FilterValue",
                    "TransferToTemp"
                }.ToArray(),
                new List<string>
                {
                    SourceApp,
                    SourceType,
                    JobNo,
                    TaskNo,
                    FilterGroup,
                    FilterValue,
                    TransferToTemp.ToBit().ToString()
                }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deleteTaskFilterValue",
                new List<string> {
                    "SourceApp",
                    "SourceType",
                    "JobNo",
                    "TaskNo",
                    "FilterGroup",
                    "FilterValue"
                }.ToArray(),
                new List<string>
                {
                    SourceApp,
                    SourceType,
                    JobNo,
                    TaskNo,
                    FilterGroup,
                    FilterValue
                }.ToArray());
    }
}