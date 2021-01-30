using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskLocked : IImportRequestable
    {
        public string SourceApp { get; set; }

        public string SourceType { get; set; }

        public string JobNo { get; set; }

        public string TaskNo { get; set; }

        public bool Locked { get; set; }

        public bool SentFromBackOfice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => new ImportRequest(
                "mboc_updateTaskLocked",
                new List<string> { "SourceApp", "SourceType", "JobNo", "TaskNo", "Locked", "SentFromBackOffice" }.ToArray(),
                new List<string> { SourceApp, SourceType, JobNo, TaskNo, Locked.ToBit().ToString(), SentFromBackOfice.ToBit().ToString() }.ToArray());
    }
}