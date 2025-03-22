using System;
using System.Linq;
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

            AppointmentResult appointmentResponse = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(appointment) as AppointmentResult;

            if (!appointmentResponse.IsSuccess)
                Assert.Fail();

            AppointmentUri model = new()
            {
                SourceType = EntityNos.SourceType,
                AppointmentGuid = guid,
                AppointmentId = appointmentResponse.Appointment,
                SourceApp = EntityNos.SourceApp,
                Description = "DESC",
                Uri = "https://www.dimescheduler.com"
            };

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}