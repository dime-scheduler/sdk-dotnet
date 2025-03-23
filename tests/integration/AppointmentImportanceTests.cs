using System;
using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
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

        [SkippableFact]
        public async System.Threading.Tasks.Task AppointmentImportance()
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

            Result appointmentResponse = await TooManyRequestRetryPolicy.ExecuteAsync(() => _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(appointment));

            if (!appointmentResponse?.IsSuccess ?? false)
                Assert.Fail();

            AppointmentImportance model = new()
            {
                SourceType = "TYPE",
                AppointmentGuid = guid,
                AppointmentId = ((AppointmentResult)appointmentResponse).Appointment,
                SentFromBackOffice = true,
                SourceApp = "APP",
                Importance = Importance.Medium
            };

            Result response = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model));
            Assert.True(response.IsSuccess, response.Error?.ToString());
        }
    }
}