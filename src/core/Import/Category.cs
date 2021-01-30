using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class Category : IImportRequestable
    {
        public Category()
        {
        }

        public Category(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string Name { get; set; }

        public string Color { get; set; }

        public ImportRequest ToImportRequest()
          => new ImportRequest(
                "mboc_upsertCategory",
                new List<string> { "CategoryName", "DisplayName", "CategoryHexColor" }.ToArray(),
                new List<string> { Name, Name, Color }.ToArray());
    }
}