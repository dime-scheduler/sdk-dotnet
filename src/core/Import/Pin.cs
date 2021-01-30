using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class Pin : Indicator, IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertPin",
                new List<string> { "Name", "HexColor" }.ToArray(),
                new List<string> { Name, Color }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deletePin",
                new List<string> { "Name" }.ToArray(),
                new List<string> { Name }.ToArray());
    }
}