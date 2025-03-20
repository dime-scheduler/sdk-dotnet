using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentTests
    {
        [Fact]
        public void Appointment_ToImportRequest_Append_AllShouldMapParameters()
        {
            Appointment model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                Start = new DateTime(2020, 1, 1),
                End = new DateTime(2020, 1, 2),
                ResourceNo = "NO",
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                BackOfficeId = "1",
                BackOfficeParentId = "2",
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
                TaskNo = "TASK",
                TimeMarker = "TM",
                UnitOfMeasure = "UOM",
                UnitOfMeasureConversion = 14,
                UseFixedPlanningQuantity = true
            };
        }
    }
}