using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class Caption : IImportRequestable
    {
        public int Context { get; set; }

        public string SourceTable { get; set; }

        public string FieldName { get; set; }

        public string Language { get; set; }

        public string Text { get; set; }

        public ImportRequest ToImportRequest()
            => new ImportRequest(
                "mboc_upsertCaption",
                new List<string> { "Context", "SourceTable", "FieldName", "Language", "Caption" }.ToArray(),
                new List<string> { Context.ToString(), SourceTable, FieldName, Language, Text }.ToArray());
    }
}