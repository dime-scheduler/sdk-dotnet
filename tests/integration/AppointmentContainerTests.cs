using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentContainerTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public AppointmentContainerTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task AppointmentContainer()
        {
            AppointmentContainer model = new()
            {
                Container = EntityNos.Container,
                Appointment = "Appointment 1"
            };

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}