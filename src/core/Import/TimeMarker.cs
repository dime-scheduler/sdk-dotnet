using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class TimeMarker : Indicator, IImportRequestable
    {
        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertTimeMarker",
                new List<string> { "TimeMarker", "HexColor" }.ToArray(),
                new List<string> { Name, Color }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deleteTimeMarker",
                new List<string> { "TimeMarker" }.ToArray(),
                new List<string> { Name }.ToArray());
    }
}