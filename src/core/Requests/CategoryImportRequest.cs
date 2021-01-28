using System.Collections.Generic;

namespace Dime.Scheduler.Sdk
{
    public class CategoryImportRequest : IImportRequestable
    {
        public CategoryImportRequest()
        {
        }

        public CategoryImportRequest(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string Name { get; set; }

        public string Color { get; set; }

        public ImportRequest ToImportRequest()
          => new ImportRequest(
                "mboc_upsertCategory",
                new List<string> { "Name", "Color" }.ToArray(),
                new List<string> { Name, Color }.ToArray());
    }
}