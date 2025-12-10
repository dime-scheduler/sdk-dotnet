using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Caption : IImportEntity
    {
        /// <summary>
        /// the context identifier.
        /// </summary>
        [Description("The context identifier.")]
        [ImportParameter(nameof(Context))]
        public int Context { get; set; } = 6;

        /// <summary>
        /// the source table name.
        /// </summary>
        [Description("The source table name.")]
        [ImportParameter(nameof(SourceTable))]
        [MaxLength(255)]
        public string SourceTable { get; set; }

        /// <summary>
        /// the field name.
        /// </summary>
        [Description("The field name.")]
        [ImportParameter(nameof(FieldName))]
        [MaxLength(255)]
        public string FieldName { get; set; }

        /// <summary>
        /// the language code.
        /// </summary>
        [Description("The language code.")]
        [ImportParameter(nameof(Language))]
        [MaxLength(10)]
        public string Language { get; set; }

        /// <summary>
        /// the caption text.
        /// </summary>
        [Description("The caption text.")]
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