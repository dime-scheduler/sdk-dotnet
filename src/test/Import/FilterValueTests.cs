using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class FilterValueTests
    {
        [Fact]
        public void FilterValue_ToImportRequest_Append_AllShouldMapParameters()
        {
            FilterValue model = new();
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}