namespace Dime.Scheduler.Sdk.Import
{
    public class FilterValue : IImportRequestable
    {
        public string Group { get; set; }
        public string Value { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertFilterValue",
                ("FilterGroupName", Group),
                ("FilterValue", Value)
            );

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deleteFilterValue",
                ("FilterGroupName", Group),
                ("FilterValue", Value)
            );
    }
}