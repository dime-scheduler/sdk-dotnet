namespace Dime.Scheduler.Sdk.Import
{
    public class TaskLocked : IImportRequestable
    {
        [ImportParameter(nameof(SourceApp))]
        public string SourceApp { get; set; }

        [ImportParameter(nameof(SourceType))]
        public string SourceType { get; set; }

        [ImportParameter(nameof(JobNo))]
        public string JobNo { get; set; }

        [ImportParameter(nameof(TaskNo))]
        public string TaskNo { get; set; }

        [ImportParameter(nameof(Locked))]
        public bool Locked { get; set; }

        [ImportParameter(nameof(SentFromBackOffice))]
        public bool SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => new(ImportProcedures.TaskLocked.Append, this.CreateParameters(transactionType));
    }
}