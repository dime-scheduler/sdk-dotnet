using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class TaskContainer : IImportRequestable, IValidatableImportRequest<TaskContainer>
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(10)]
        public string SourceType { get; set; }

        [ImportParameter(nameof(JobNo))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        public string JobNo { get; set; }

        [ImportParameter(nameof(TaskNo))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        public string TaskNo { get; set; }

        [ImportParameter("ContainerName")]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(255)]
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
            => new(ImportProcedures.TaskContainer.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.TaskContainer.Delete, this.CreateParameters(TransactionType.Delete));

        TaskContainer IValidatableImportRequest<TaskContainer>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<TaskContainer>(validationContext);
    }
}