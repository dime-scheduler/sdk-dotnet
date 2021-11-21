using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskUri : IImportRequestable
    {
        [ImportParameter(nameof(SourceApp))]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        [ImportParameter(nameof(SourceType))]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(10)]
        public string SourceType { get; set; }

        [ImportParameter(nameof(JobNo))]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string JobNo { get; set; }

        [ImportParameter(nameof(TaskNo))]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string TaskNo { get; set; }

        [ImportParameter("url")]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(1000)]
        public string Uri { get; set; }

        [ImportParameter("urldesc")]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(255)]
        public string Description { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Task.Uri.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException("Action does not exist yet in Dime.Scheduler");
    }
}