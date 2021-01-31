using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Dime.Scheduler.Sdk.Import
{
    public class TaskContainer : IImportRequestable, IValidatableObject
    {
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        public string SourceApp { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        public string SourceType { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        public string JobNo { get; set; }

        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        public string TaskNo { get; set; }

        [RequiredIf(TransactionType.Append)]
        public string Name { get; set; }

        public int Index { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? Validate(transactionType).CreateAppendRequest()
                : Validate(transactionType).CreateDeleteRequest();

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

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            validationContext.Items.TryGetValue("transactionType", out object? transactionType);

            List<ValidationResult> results = new List<ValidationResult>();
            Validator.TryValidateProperty(SourceApp, new ValidationContext(this, null, null) { Items = { { "transactionType", transactionType } }, MemberName = nameof(SourceApp) }, results);
            Validator.TryValidateProperty(Name, new ValidationContext(this, null, null) { Items = { { "transactionType", transactionType } }, MemberName = nameof(Name) }, results);

            return results;
        }

        private TaskContainer Validate(TransactionType transactionType)
        {
            ValidationContext validationContext = new ValidationContext(this)
            {
                Items = { { "transactionType", transactionType } }
            };

            IEnumerable<ValidationResult> result = (this as IValidatableObject).Validate(validationContext);
            if (!result.Any())
                return this;

            string validationExceptionMsg = string.Join(Environment.NewLine, result.Select(x => x.ErrorMessage));
            throw new Exception(validationExceptionMsg);
        }
    }
}