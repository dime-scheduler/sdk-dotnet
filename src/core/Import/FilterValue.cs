using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class FilterValue : IImportRequestable
    {
        [ImportParameter("FilterGroupName")]
        public string Group { get; set; }

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
            => new ImportRequest(ImportProcedures.FilterValue.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(ImportProcedures.FilterValue.Delete, this.CreateParameters(TransactionType.Delete));
    }
}