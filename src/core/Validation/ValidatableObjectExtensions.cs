using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Dime.Scheduler.Entities
{
    internal static class ValidatableObjectExtensions
    {
        internal static IEnumerable<ValidationResult> Validate<T>(this IImportRequestable request, ValidationContext validationContext)
        {
            List<ValidationResult> results = [];

            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
                Validator.TryValidateProperty(
                    property.GetValue(request),
                    request.CreateValidationContext(validationContext, property.Name), results);

            return results;
        }

        private static ValidationContext CreateValidationContext(this IImportRequestable request, ValidationContext validationContext, string property)
        {
            validationContext.Items.TryGetValue("transactionType", out object? transactionType);
            KeyValuePair<object, object?> keyValuePair = new("transactionType", transactionType);

            return new ValidationContext(request, null, null) { Items = { keyValuePair }, MemberName = property };
        }
    }
}