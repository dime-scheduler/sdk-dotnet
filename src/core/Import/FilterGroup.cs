using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class FilterGroup : IImportRequestable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ColumnNo { get; set; }
        public bool DataFilter { get; set; }

        public ImportRequest ToImportRequest()
         => new ImportRequest(
                "mboc_upsertFilterGroup",
                new List<string> { "Id", "GroupName", "ColumnNo", "DataFilter" }.ToArray(),
                new List<string> { Id.ToString(), Name, ColumnNo.ToString(), DataFilter ? "1" : "0" }.ToArray());
    }
}