using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class Caption : IImportRequestable
    {
        public ImportRequest ToImportRequest()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Pin : Indicator, IImportRequestable
    {
        public ImportRequest ToImportRequest()
        => new ImportRequest(
                "mboc_upsertCategory",
                new List<string> { "Name", "HexColor" }.ToArray(),
                new List<string> { Name, Color }.ToArray());
    }
}