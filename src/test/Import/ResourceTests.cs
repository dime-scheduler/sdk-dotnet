using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class ResourceTests
    {
        [Fact]
        public void Resource_ToImportRequest_Append_AllShouldMapParameters()
        {
            Dime.Scheduler.Sdk.Import.Resource model = new()
            {
                ResourceNo = "Resource"
            };
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}