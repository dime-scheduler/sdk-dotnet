using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentLockedTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public AppointmentLockedTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task AppointmentLocked()
        {
            AppointmentLocked model = new()
            {
                SourceApp = "BC001",
                SourceType = "BC001",
                AppointmentId = 1,
                AppointmentGuid = Guid.NewGuid(),
                Locked = true,
                SentFromBackOffice = true
            };

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}