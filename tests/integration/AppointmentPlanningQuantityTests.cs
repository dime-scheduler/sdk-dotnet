using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
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
        public async System.Threading.Tasks.Task AppointmentPlanningQuantity()
        {
            AppointmentPlanningQuantity model = CreateModel();
        }
    }
}