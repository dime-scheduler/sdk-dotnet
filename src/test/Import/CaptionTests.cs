using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class CaptionTests
    {
        [Fact]
        public void Caption_ToImportRequest_Append_AllShouldMapParameters()
        {
            Caption model = new();
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}