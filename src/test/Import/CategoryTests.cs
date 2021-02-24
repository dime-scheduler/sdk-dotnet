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
                DisplayName = "Category 1"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}