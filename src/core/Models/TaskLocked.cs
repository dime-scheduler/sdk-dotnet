using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Models
{
    public class TaskLocked : IImportRequestable
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp))]
        [Required]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType))]
        [Required]
        [MaxLength(10)]
        public string SourceType { get; set; }

        [ImportParameter(nameof(JobNo))]
        [Required]
        [MaxLength(50)]
        public string JobNo { get; set; }

        [ImportParameter(nameof(TaskNo))]
        [Required]
        [MaxLength(50)]
        public string TaskNo { get; set; }

        [ImportParameter(nameof(Locked))]
        public bool Locked { get; set; }

        [ImportParameter(nameof(SentFromBackOffice))]
        public bool SentFromBackOffice { get; set; } = true;

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => new(ImportProcedures.TaskLocked.Append, this.CreateParameters(transactionType));
    }
}