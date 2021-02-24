using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class ResourceFilterValueTests
    {
        [Fact]
        public void ResourceFilterValue_ToImportRequest_Append_AllShouldMapParameters()
        {
            ResourceFilterValue model = new();
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}