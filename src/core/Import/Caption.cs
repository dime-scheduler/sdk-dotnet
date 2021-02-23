using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class Caption : IImportRequestable
    {
        [ImportParameter(nameof(Context))]
        public int Context { get; set; }

        [ImportParameter(nameof(SourceTable))]
        public string SourceTable { get; set; }

        [ImportParameter(nameof(FieldName))]
        public string FieldName { get; set; }

        [ImportParameter(nameof(Language))]
        public string Language { get; set; }

        [ImportParameter("Caption")]
        public string Text { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Caption.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Caption.Delete, this.CreateParameters(TransactionType.Delete));
    }
}