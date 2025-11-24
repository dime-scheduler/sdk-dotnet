using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class TaskLocked : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [Description("Identifies the record's originating system.")]
        [ImportParameter(nameof(SourceApp))]
        [Required]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [Description("Identifies the record's type in the originating system.")]
        [ImportParameter(nameof(SourceType))]
        [Required]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/JobNo/*'/>
        [Description("Identifies the job.")]
        [ImportParameter(nameof(JobNo))]
        [Required]
        [MaxLength(50)]
        public string JobNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/Taskno/*'/>
        [Description("Identifies the task.")]
        [ImportParameter(nameof(TaskNo))]
        [Required]
        [MaxLength(50)]
        public string TaskNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Locked/*'/>
        [Description("Indicates whether the item is locked.")]
        [ImportParameter(nameof(Locked))]
        public bool Locked { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/SentFromBackOffice/*'/>
        [Description("Indicates whether the request was sent from back office.")]
        [ImportParameter(nameof(SentFromBackOffice))]
        public bool SentFromBackOffice { get; set; } = true;

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => new(ImportProcedures.TaskLocked.Append, this.CreateParameters(transactionType));
    }
}