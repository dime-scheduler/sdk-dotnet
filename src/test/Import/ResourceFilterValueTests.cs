using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class ResourceFilterValueTests
    {
        [Fact]
        public void ResourceFilterValue_ToImportRequest_Append_AllShouldMapParameters()
        {
            ResourceFilterValue model = new()
            {
                FilterGroup = "GROUP",
                FilterValue = "VALUE",
                ResourceNo = "NO",
                SourceApp = "APP",
                SourceType = "TYPE",
                TransferToTemp = true
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}