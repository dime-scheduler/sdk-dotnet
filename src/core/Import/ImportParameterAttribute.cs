using System;
using System.Collections.Generic;
using System.Linq;

namespace Dime.Scheduler.Entities
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

        public bool ShouldInclude(TransactionType type) => !TransactionTypes.Any() || TransactionTypes.Any(x => x == type);
    }
}