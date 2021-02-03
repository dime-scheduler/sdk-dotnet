using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskContainer : IImportRequestable, IValidatableImportRequest<TaskContainer>
    {
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(30)]
        [ImportParameter(nameof(SourceApp))]
        public string SourceApp { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(10)]
        [ImportParameter(nameof(SourceType))]
        public string SourceType { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        [ImportParameter(nameof(JobNo))]
        public string JobNo { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        [ImportParameter(nameof(TaskNo))]
        public string TaskNo { get; set; }

        [RequiredIf(TransactionType.Append)]
        [MaxLength(255)]
        [ImportParameter("ContainerName")]
        public string Name { get; set; }

        [ImportParameter(nameof(Index), TransactionType.Append)]
        public int Index { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<TaskContainer>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<TaskContainer>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(ImportProcedures.TaskContainer.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(ImportProcedures.TaskContainer.Delete, this.CreateParameters(TransactionType.Delete));

        TaskContainer IValidatableImportRequest<TaskContainer>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<TaskContainer>(validationContext);
    }
}