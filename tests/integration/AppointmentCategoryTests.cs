using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentCategoryTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public AppointmentCategoryTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        private static AppointmentCategory CreateModel()
            => new()
            {
                SourceType = "TYPE",
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                Category = "CAT",
                SentFromBackOffice = true,
                SourceApp = "APP"
            };

        [Fact]
        public async System.Threading.Tasks.Task AppointmentCategory()
        {
            AppointmentCategory model = CreateModel();

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}