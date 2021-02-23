using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskFilterValue : IImportRequestable
    {
        [ImportParameter(nameof(SourceApp))]
        public string SourceApp { get; set; }

        [ImportParameter(nameof(SourceType))]
        public string SourceType { get; set; }

        [ImportParameter(nameof(JobNo))]
        public string JobNo { get; set; }

        [ImportParameter(nameof(TaskNo))]
        public string TaskNo { get; set; }

        [ImportParameter(nameof(FilterGroup))]
        public string FilterGroup { get; set; }

        [ImportParameter(nameof(FilterValue))]
        public string FilterValue { get; set; }

        [ImportParameter(nameof(TransferToTemp), TransactionType.Append)]
        public bool TransferToTemp { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(
                ImportProcedures.Task.FilterValue.Append,
                this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(
                ImportProcedures.Task.FilterValue.Delete,
                this.CreateParameters(TransactionType.Delete));
    }
}