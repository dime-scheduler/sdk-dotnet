using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class FilterGroup : IImportRequestable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ColumnNo { get; set; }
        public bool DataFilter { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertFilterGroup",
                new List<string> { "Id", "GroupName", "ColumnNo", "DataFilter" }.ToArray(),
                new List<string> { Id.ToString(), Name, ColumnNo.ToString(), DataFilter ? "1" : "0" }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deleteFilterGroup",
                new List<string> { "GroupName" }.ToArray(),
                new List<string> { Name }.ToArray());
    }
}