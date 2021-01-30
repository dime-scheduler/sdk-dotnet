using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskContainer : IImportRequestable
    {
        public string SourceApp { get; set; }

        public string SourceType { get; set; }

        public string JobNo { get; set; }

        public string TaskNo { get; set; }

        public string Name { get; set; }

        public int Index { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertTaskContainer",
                new List<string> {
                    "SourceApp",
                    "SourceType",
                    "JobNo",
                    "TaskNo",
                    "ContainerName",
                    "Index"
                }.ToArray(),
                new List<string>
                {
                    SourceApp,
                    SourceType,
                    JobNo,
                    TaskNo,
                    Name,
                    Index.ToString()
                }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deleteTaskContainer",
                new List<string> {
                    "SourceApp",
                    "SourceType",
                    "JobNo",
                    "TaskNo",
                    "ContainerName"
                }.ToArray(),
                new List<string>
                {
                    SourceApp,
                    SourceType,
                    JobNo,
                    TaskNo,
                    Name
                }.ToArray());
    }
}