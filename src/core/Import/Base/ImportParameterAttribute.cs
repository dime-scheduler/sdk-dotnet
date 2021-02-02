using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Dime.Scheduler.Sdk.Import
{
    public class ImportParameterAttribute : Attribute
    {
        public ImportParameterAttribute(string name, params TransactionType[] transactionTypes)
        {
            Name = name;
            TransactionTypes = transactionTypes?.ToList() ?? new List<TransactionType>();
        }

        public string Name { get; }

        private IEnumerable<TransactionType> TransactionTypes { get; }

        public bool IsValid(TransactionType type) => TransactionTypes.Any(x => x == type);
    }
}