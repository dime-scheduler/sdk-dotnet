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
                SourceType = EntityNos.SourceType,
                AppointmentGuid = EntityNos.AppointmentGuid,
                AppointmentId = 1,
                SourceApp = EntityNos.SourceApp,
                Quantity = 5
            };

        [SkippableFact]
        public async System.Threading.Tasks.Task AppointmentPlanningQuantity()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            AppointmentPlanningQuantity model = CreateModel();

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}