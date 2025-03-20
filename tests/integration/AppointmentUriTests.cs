using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentUriTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public AppointmentUriTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task AppointmentUri()
        {
            AppointmentUri model = new()
            {
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SourceApp = "APP",
                SourceType = "TYPE",
                Description = "DESC",
                Uri = "URI"
            };

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}