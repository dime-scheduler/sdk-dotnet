using System;
using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
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

        [SkippableFact]
        public async System.Threading.Tasks.Task AppointmentUri()
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
                AppointmentId = 1,
                ResourceNo = EntityNos.Resource,
                Start = DateTime.Now,
                End = DateTime.Now.AddHours(1),
            };

            Result appointmentResponse = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(appointment));           
            if (!appointmentResponse.IsSuccess)
                Assert.Fail();

            AppointmentUri model = new()
            {
                SourceType = EntityNos.SourceType,
                AppointmentGuid = guid,
                AppointmentId = ((AppointmentResult)appointmentResponse).Appointment,
                SourceApp = EntityNos.SourceApp,
                Description = "DESC",
                Uri = "https://www.dimescheduler.com"
            };

            Result response = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model));
            Assert.True(response.IsSuccess, response.Error?.ToString());
        }
    }
}