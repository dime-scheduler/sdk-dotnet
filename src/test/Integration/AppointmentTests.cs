using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class AppointmentTests
    {
        internal static Appointment Test => new()
        {
            SourceApp = "POWERAPPS",
            SourceType = "POWERAPPS",
            JobNo = "POWERAPP_001",
            TaskNo = "T123",
            Start = DateTime.Now,
            End = DateTime.Now.AddHours(2),
            ResourceNo = "BULENS",
            Body = "Hello from SDK's unit tests",
            Subject = "Unit test",
            Category = "OFFICE",
            Importance = Importance.High,
            UseFixedPlanningQuantity = true
        };

        [Fact]
        public async t.Task Appointment_Append_ShouldCreateAppointment()
        {
            ImportRequest importRequest = Test.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(importRequest));
        }
    }
}