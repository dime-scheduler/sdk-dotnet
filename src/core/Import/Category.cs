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

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertCategory",
                new List<string> { "CategoryName", "DisplayName", "CategoryHexColor" }.ToArray(),
                new List<string> { Name, Name, Color }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deleteCategory",
                new List<string> { "CategoryName" }.ToArray(),
                new List<string> { Name }.ToArray());
    }
}