using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class AppointmentedLockedTests
    {
        [Fact]
        public void AppointmentLocked_ToImportRequest_ShouldMapParameters()
        {
            AppointmentLocked model = new AppointmentLocked { SourceApp = "BC001", SourceType = "BC001" };
            ImportRequest importRequest = (model as IImportRequestable).ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[0] == "SourceApp");
            Assert.True(importRequest.ParameterValues[0] == "BC001");
        }
    }
}