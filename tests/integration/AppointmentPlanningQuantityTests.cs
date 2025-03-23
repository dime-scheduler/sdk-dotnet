using System;
using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
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

        [SkippableFact]
        public async System.Threading.Tasks.Task AppointmentPlanningQuantity()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            Guid guid = Guid.NewGuid();

            Appointment appointment = new()
            {
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                JobNo = EntityNos.Job,
                TaskNo = EntityNos.Task,
                AppointmentGuid = guid,
                ResourceNo = EntityNos.Resource,
                Start = DateTime.Now,
                End = DateTime.Now.AddHours(1),
                UseFixedPlanningQuantity = true
            };

            Result appointmentResponse = await TooManyRequestRetryPolicy.ExecuteAsync(() => _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(appointment));

            if (!appointmentResponse.IsSuccess)
                Assert.Fail();

            AppointmentPlanningQuantity model = new()
            {
                SourceType = EntityNos.SourceType,
                AppointmentGuid = guid,
                AppointmentId = ((AppointmentResult)appointmentResponse).Appointment,
                SourceApp = EntityNos.SourceApp,
                Quantity = 5
            };

            Result response = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model));
            Assert.True(response.IsSuccess, response.Error?.ToString());
        }
    }
}