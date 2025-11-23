using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class TaskLocked : IImportEntity
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

        /// <include file='docs.xml' path='docs/members[@name="Work"]/JobNo/*'/>
        [ImportParameter(nameof(JobNo))]
        [Required]
        [MaxLength(50)]
        public string JobNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/Taskno/*'/>
        [ImportParameter(nameof(TaskNo))]
        [Required]
        [MaxLength(50)]
        public string TaskNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Locked/*'/>
        [ImportParameter(nameof(Locked))]
        public bool Locked { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/SentFromBackOffice/*'/>
        [ImportParameter(nameof(SentFromBackOffice))]
        public bool SentFromBackOffice { get; set; } = true;

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => new(ImportProcedures.TaskLocked.Append, this.CreateParameters(transactionType));
    }
}