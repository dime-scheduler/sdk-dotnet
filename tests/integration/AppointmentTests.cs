using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public AppointmentTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task Appointment()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            Appointment model = new()
            {
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                Start = new DateTime(2020, 1, 1),
                End = new DateTime(2020, 1, 2),
                ResourceNo = EntityNos.Resource,
                AppointmentGuid = EntityNos.AppointmentGuid,
                SentFromBackOffice = true,
                Body = "Body",
                Subject = "Subject",
                Category = "CAT",
                Importance = Importance.High,
                IsAllDay = false,
                JobNo = "Job",
                Locked = true,
                PlanningQuantity = 525,
                ReplaceResource = true,
                RoundToUnitOfMeasure = true,
                TaskNo = EntityNos.Task,
                TimeMarker = "TM",
                UnitOfMeasure = "UOM",
                UnitOfMeasureConversion = 14,
                UseFixedPlanningQuantity = true
            };

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}