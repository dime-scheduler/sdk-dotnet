using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Caption : IImportEntity
    {
        [ImportParameter(nameof(Context))]
        public int Context { get; set; } = 6;

        [ImportParameter(nameof(SourceTable))]
        [MaxLength(255)]
        public string SourceTable { get; set; }

        [ImportParameter(nameof(FieldName))]
        [MaxLength(255)]
        public string FieldName { get; set; }

        [ImportParameter(nameof(Language))]
        [MaxLength(10)]
        public string Language { get; set; }

        [ImportParameter("Caption")]
        [MaxLength(100)]
        public string Text { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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