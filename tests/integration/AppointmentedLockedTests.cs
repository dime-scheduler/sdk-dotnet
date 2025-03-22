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

        [SkippableFact]
        public async System.Threading.Tasks.Task AppointmentLocked()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            AppointmentLocked model = new()
            {
                SourceType = EntityNos.SourceType,
                AppointmentGuid = EntityNos.AppointmentGuid,
                AppointmentId = 1,
                SourceApp = EntityNos.SourceApp,
                Locked = true
            };

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}