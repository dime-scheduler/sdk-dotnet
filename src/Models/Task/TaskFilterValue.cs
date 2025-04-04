﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class TaskFilterValue : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(10)]
        public string SourceType { get; set; }

        [ImportParameter(nameof(JobNo))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        public string JobNo { get; set; }

        [ImportParameter(nameof(TaskNo))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        public string TaskNo { get; set; }

        [ImportParameter(nameof(FilterGroup))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        public string FilterGroup { get; set; }

        [ImportParameter(nameof(FilterValue))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        [MaxLength(100)]
        public string FilterValue { get; set; }

        [ImportParameter(nameof(TransferToTemp), TransactionType.Append)]
        public bool TransferToTemp { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        public ImportRequest ToImportRequest(TransactionType transactionType, bool clear = false)
            => clear ? CreateClearRequest() : ((IImportEntity)this).ToImportRequest(transactionType);

        private ImportRequest CreateAppendRequest()
            => new(
                ImportProcedures.Task.FilterValue.Append,
                this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(
                ImportProcedures.Task.FilterValue.Delete,
                this.CreateParameters(TransactionType.Delete));

        private ImportRequest CreateClearRequest()
            => new(ImportProcedures.Task.FilterValue.Clear,
                new ImportParameter(nameof(SourceApp), SourceApp),
                new ImportParameter(nameof(SourceType), SourceType),
                new ImportParameter(nameof(JobNo), JobNo),
                new ImportParameter(nameof(TaskNo), TaskNo));
    }
}