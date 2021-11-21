using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskFilterValue : IImportRequestable
    {
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [ImportParameter(nameof(SourceApp))]
        public string SourceApp { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [ImportParameter(nameof(SourceType))]
        public string SourceType { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [ImportParameter(nameof(JobNo))]
        public string JobNo { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [ImportParameter(nameof(TaskNo))]
        public string TaskNo { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [ImportParameter(nameof(FilterGroup))]
        public string FilterGroup { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
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
        public ImportRequest ToImportRequest(TransactionType transactionType, bool clear = false)
            => clear ? CreateClearRequest() : ((IImportRequestable)this).ToImportRequest(transactionType);

        private ImportRequest CreateAppendRequest()
            => new(
                ImportProcedures.Task.FilterValue.Append,
                this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(
                ImportProcedures.Task.FilterValue.Delete,
                this.CreateParameters(TransactionType.Delete));

        private ImportRequest CreateClearRequest()
            => new(ImportProcedures.Task.FilterValue.Clear,
                new ImportParameter(nameof(SourceApp), SourceApp),
                new ImportParameter(nameof(SourceType), SourceType),
                new ImportParameter(nameof(JobNo), JobNo),
                new ImportParameter(nameof(TaskNo), TaskNo));
    }
}