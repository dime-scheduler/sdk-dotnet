using System;

namespace Dime.Scheduler.Entities
{
    public class ResourceFilterValue : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp))]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType))]
        public string SourceType { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [ImportParameter(nameof(ResourceNo))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        public string ResourceNo { get; set; }

        /// <summary>
        /// Gets or sets the filter group name.
        /// </summary>
        [ImportParameter(nameof(FilterGroup))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        public string FilterGroup { get; set; }

        /// <summary>
        /// Gets or sets the filter value.
        /// </summary>
        [ImportParameter(nameof(FilterValue))]
        [RequiredIf(TransactionType.Append, TransactionType.Delete)]
        public string FilterValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to transfer to temporary storage.
        /// </summary>
        [ImportParameter(nameof(TransferToTemp), TransactionType.Append)]
        public bool TransferToTemp { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        internal ImportRequest ToImportRequest(TransactionType transactionType, bool clear = false)
            => clear ? CreateClearRequest() : ((IImportEntity)this).ToImportRequest(transactionType);

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Resource.FilterValue.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Resource.FilterValue.Delete, this.CreateParameters(TransactionType.Delete));

        private ImportRequest CreateClearRequest()
            => new(ImportProcedures.Resource.FilterValue.Clear,
                new ImportParameter(nameof(SourceApp), SourceApp),
                new ImportParameter(nameof(SourceType), SourceType),
                new ImportParameter(nameof(ResourceNo), ResourceNo));
    }
}