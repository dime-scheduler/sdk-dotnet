using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class FilterValue : IImportRequestable
    {
        public int Group { get; set; }
        public string Value { get; set; }

        public ImportRequest ToImportRequest()
         => new ImportRequest(
                "mboc_upsertFilterValue",
                new List<string> { "FilterGroupName", "FilterValue" }.ToArray(),
                new List<string> { "Group", "Value" }.ToArray());
    }
}