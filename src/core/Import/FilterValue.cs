using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class FilterValue : IImportRequestable
    {
        public FilterValue()
        {
        }

        public FilterValue(string group, string value)
        {
            Group = group;
            Value = value;
        }

        [MaxLength(50)]
        [ImportParameter("FilterGroupName")]
        public string Group { get; set; }

        [MaxLength(100)]
        [ImportParameter("FilterValue")]
        public string Value { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.FilterValue.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.FilterValue.Delete, this.CreateParameters(TransactionType.Delete));
    }
}