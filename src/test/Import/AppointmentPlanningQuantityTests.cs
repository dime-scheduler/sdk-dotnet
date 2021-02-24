using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class AppointmentPlanningQuantityTests
    {
        [Fact]
        public void AppointmentPlanningQuantity_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentPlanningQuantity model = new()
            {
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                SourceApp = "APP",
                SourceType = "TYPE",
                Quantity = 5
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}