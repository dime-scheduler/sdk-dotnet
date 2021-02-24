using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class TimeMarkerTests
    {
        [Fact]
        public void TimeMarker_ToImportRequest_Append_AllShouldMapParameters()
        {
            TimeMarker model = new()
            {
                Name = "MARKER 1"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}