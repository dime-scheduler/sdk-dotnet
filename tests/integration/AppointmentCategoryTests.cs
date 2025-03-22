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
                SourceType = EntityNos.SourceType,
                AppointmentGuid = EntityNos.AppointmentGuid,
                Category = EntityNos.Category,
                SourceApp = EntityNos.SourceApp
            };

        [SkippableFact]
        public async System.Threading.Tasks.Task AppointmentCategory()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            AppointmentCategory model = CreateModel();

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}