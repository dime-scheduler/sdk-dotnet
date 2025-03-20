using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentImportanceTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public AppointmentImportanceTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        private static AppointmentImportance CreateModel()
            => new()
            {
                SourceType = "TYPE",
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                SourceApp = "APP",
                Importance = Importance.Medium
            };

        [Fact]
        public async System.Threading.Tasks.Task AppointmentImportance()
        {
            AppointmentImportance model = CreateModel();

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}