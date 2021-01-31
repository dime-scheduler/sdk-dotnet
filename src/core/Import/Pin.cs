using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Pin : Indicator, IImportRequestable, IValidatableImportRequest<Pin>
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? ((IValidatableImportRequest<Pin>)this).Validate(transactionType).CreateAppendRequest()
                : ((IValidatableImportRequest<Pin>)this).Validate(transactionType).CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertPin",
                new List<string> { "Name", "HexColor" }.ToArray(),
                new List<string> { Name, Color }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deletePin",
                new List<string> { "Name" }.ToArray(),
                new List<string> { Name }.ToArray());

        Pin IValidatableImportRequest<Pin>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Pin>(validationContext);
    }
}