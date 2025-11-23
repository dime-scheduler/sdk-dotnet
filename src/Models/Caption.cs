using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Caption : IImportEntity
    {
        /// <summary>
        /// Gets or sets the context identifier.
        /// </summary>
        [ImportParameter(nameof(Context))]
        public int Context { get; set; } = 6;

        /// <summary>
        /// Gets or sets the source table name.
        /// </summary>
        [ImportParameter(nameof(SourceTable))]
        [MaxLength(255)]
        public string SourceTable { get; set; }

        /// <summary>
        /// Gets or sets the field name.
        /// </summary>
        [ImportParameter(nameof(FieldName))]
        [MaxLength(255)]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or sets the language code.
        /// </summary>
        [ImportParameter(nameof(Language))]
        [MaxLength(10)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the caption text.
        /// </summary>
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