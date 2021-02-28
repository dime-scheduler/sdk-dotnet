using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class CategoryTests
    {
        [Fact]
        public void Category_ToImportRequest_Append_AllShouldMapParameters()
        {
            Category model = new()
            {
                Name = "CATEGORY_1",
                DisplayName = "Category 1",
                Color = "BLUE"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Category_Constructor_ToImportRequest_Append_AllShouldMapParameters()
        {
            Category model = new("Hello world", "Blue");
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Category_Constructor_ToImportRequest_Delete_AllShouldMapParameters()
        {
            Category model = new("Hello world", "Blue");
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}