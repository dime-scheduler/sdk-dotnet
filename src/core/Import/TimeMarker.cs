using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class TimeMarker : Indicator, IImportRequestable
    {
        public ImportRequest ToImportRequest()
         => new ImportRequest(
                "mboc_upsertCategory",
                new List<string> { "TimeMarker", "HexColor" }.ToArray(),
                new List<string> { Name, Color }.ToArray());
    }
}