using Dime.Scheduler.Sdk.Models;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class ResourceFilterValueTests
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

        [Fact]
        public void ResourceFilterValue_ToImportRequest_Delete_AllShouldMapParameters()
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

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void ResourceFilterValue_ToImportRequest_Clear_AllShouldMapParameters()
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

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete, true);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}