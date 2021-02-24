using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class AssignmentTests
    {
        [Fact]
        public void Assignment_ToImportRequest_Append_AllShouldMapParameters()
        {
            Assignment model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                ResourceNo = "LINDA"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}