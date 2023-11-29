using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class AppointmentPlanningQuantityTests
    {
        private static AppointmentPlanningQuantity CreateModel()
            => new()
            {
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                SourceApp = "APP",
                SourceType = "TYPE",
                Quantity = 5
            };

        [Fact]
        public void AppointmentPlanningQuantity_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentPlanningQuantity model = CreateModel();

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void AppointmentPlanningQuantity_ToImportRequest_Delete_ShouldThrowException()
        {
            AppointmentPlanningQuantity model = CreateModel();

            model.ShouldNotCreateImportRequest(TransactionType.Delete);
        }
    }
}