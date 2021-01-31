using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Dime.Scheduler.Sdk.Import
{
    internal static class ValidatableImportRequestExtensions
    {
        internal static T Validate<T>(this T request, TransactionType transactionType)
        {
            KeyValuePair<object, object?> keyValuePair = new KeyValuePair<object, object?>("transactionType", transactionType);
            ValidationContext validationContext = new ValidationContext(request) { Items = { keyValuePair } };

            IEnumerable<ValidationResult> result = (request as IValidatableObject).Validate(validationContext);
            if (!result.Any())
                return request;

            string validationExceptionMsg = string.Join(Environment.NewLine, result.Select(x => x.ErrorMessage));
            throw new Exception(validationExceptionMsg);
        }
    }
}