﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class FilterValue : IImportEntity
    {
        public FilterValue()
        {
        }

        public FilterValue(string group, string value)
        {
            Group = group;
            Value = value;
        }

        [ImportParameter("FilterGroupName")]
        [MaxLength(50)]
        [Required]
        public string Group { get; set; }

        [ImportParameter("FilterValue")]
        [MaxLength(100)]
        [Required]
        public string Value { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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