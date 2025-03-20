using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentPlanningQuantityTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public AppointmentPlanningQuantityTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

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

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}