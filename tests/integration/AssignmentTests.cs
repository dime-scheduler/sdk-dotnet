using System;
using System.Linq;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AssignmentTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public AssignmentTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task Assignment()
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
            };

            Result appointmentResponse = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(appointment);

            if (!appointmentResponse.IsSuccess)
                Assert.Fail();

            Assignment model = new()
            {
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                ResourceNo = EntityNos.Resource,
                SentFromBackOffice = true,
                AppointmentId = appointmentResponse.Appointments.ElementAt(0)?.Id ?? (long)0,
                AppointmentGuid = guid,
            };

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}