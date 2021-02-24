using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class AppointmentTimeMarkerTests
    {
        [Fact]
        public void AppointmentTimeMarker_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentTimeMarker model = new();
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}