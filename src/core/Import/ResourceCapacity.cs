using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceCapacity : IImportRequestable, IValidatableObject
    {
        [Required]
        public string ResourceNo { get; set; }

        public DateTime Date { get; set; }

        public int CapacityInSeconds { get; set; }

        public int Quantity { get; set; }

        public string UnitOfMeasure { get; set; }

        public decimal UnitOfMeasureConversion { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? Validate().CreateAppendRequest()
                : Validate().CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertResourceCapacity",
                new List<string> {
                    "ResourceNo",
                    "CapacityDate",
                    "CapacityInSeconds",
                    "CapacityQty",
                    "CapacityUOM",
                    "CapacityUOMConversion"
                }.ToArray(),
                new List<string>
                {
                   ResourceNo,
                   Date.ToString("s"),
                   CapacityInSeconds.ToString(),
                   Quantity.ToString(),
                   UnitOfMeasure,
                   UnitOfMeasureConversion.ToString()
                }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException();

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            Validator.TryValidateProperty(ResourceNo, new ValidationContext(this, null, null) { MemberName = nameof(ResourceNo) }, results);

            return results;
        }

        private ResourceCapacity Validate()
        {
            IEnumerable<ValidationResult> result = (this as IValidatableObject).Validate(new ValidationContext(this));
            if (!result.Any())
                return this;

            string validationExceptionMsg = string.Join(Environment.NewLine, result.Select(x => x.ErrorMessage));
            throw new Exception(validationExceptionMsg);
        }
    }
}