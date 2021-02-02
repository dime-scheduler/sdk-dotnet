namespace Dime.Scheduler.Sdk.Import
{
    public class FilterValue : IImportRequestable
    {
        [ImportParameter("FilterGroupName", TransactionType.Append, TransactionType.Delete)]
        public string Group { get; set; }

        [ImportParameter("FilterValue", TransactionType.Append, TransactionType.Delete)]
        public string Value { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(ImportProcedures.AppendFilterValue, this.CreateParameters<FilterValue>(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(ImportProcedures.DeleteFilterValue, this.CreateParameters<FilterValue>(TransactionType.Delete));
    }
}