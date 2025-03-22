using System;
using System.Collections.Generic;
using System.Linq;

namespace Dime.Scheduler.Entities
{
    internal class ImportParameterAttribute : Attribute
    {
        internal ImportParameterAttribute(string name, params TransactionType[] transactionTypes)
        {
            Name = name;
            TransactionTypes = transactionTypes?.ToList() ?? [];
        }

        public string Name { get; }

        private IEnumerable<TransactionType> TransactionTypes { get; }

        public bool ShouldInclude(TransactionType type) => !TransactionTypes.Any() || TransactionTypes.Any(x => x == type);
    }
}