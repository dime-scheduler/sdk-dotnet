using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Dime.Scheduler.Sdk.Models
{
    public class RequiredIfAttribute : RequiredAttribute
    {
        public RequiredIfAttribute(params TransactionType[] transactionTypes)
        {
            TransactionTypes = transactionTypes?.ToList() ?? new List<TransactionType>();
        }

        private IEnumerable<TransactionType> TransactionTypes { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            context.Items.TryGetValue("transactionType", out object? transactionType);

            if (transactionType == null)
                throw new ArgumentNullException(nameof(transactionType));

            return TransactionTypes.Any(x => x == (TransactionType)transactionType) ? base.IsValid(value, context) : null;
        }
    }
}