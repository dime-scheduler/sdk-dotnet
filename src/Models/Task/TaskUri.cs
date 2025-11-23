using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class TaskUri : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp))]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType))]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/JobNo/*'/>
        [ImportParameter(nameof(JobNo))]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string JobNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/Taskno/*'/>
        [ImportParameter(nameof(TaskNo))]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string TaskNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Uri/*'/>
        [ImportParameter("url")]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(1000)]
        public string Uri { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [ImportParameter("urldesc")]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(255)]
        public string Description { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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