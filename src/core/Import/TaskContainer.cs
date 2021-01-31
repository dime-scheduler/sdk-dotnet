using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskContainer : IImportRequestable, IValidatableImportRequest<TaskContainer>
    {
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(10)]
        public string SourceType { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        public string JobNo { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        public string TaskNo { get; set; }

        [RequiredIf(TransactionType.Append)]
        [MaxLength(255)]
        public string Name { get; set; }

        public int Index { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? ((IValidatableImportRequest<TaskContainer>)this).Validate(transactionType).CreateAppendRequest()
                : ((IValidatableImportRequest<TaskContainer>)this).Validate(transactionType).CreateDeleteRequest();

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

        TaskContainer IValidatableImportRequest<TaskContainer>.Validate(TransactionType transactionType) 
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<TaskContainer>(validationContext);
    }
}