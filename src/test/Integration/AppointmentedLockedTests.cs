using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class AppointmentLockedTests
    {
        [Fact]
        public async t.Task AppointmentLocked_Append_ShouldCreateAppointment()
        {
            ImportRequest appointmentBaseRequest = AppointmentTests.Test.ToImportRequest(TransactionType.Append);
            long appointment = await DimeScheduler.DoAppointmentImportRequest(appointmentBaseRequest);

            AppointmentLocked appointmentLocked = new()
            {
                AppointmentId = appointment,
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                Locked = true
            };

            ImportRequest appointmentLockedRequest = appointmentLocked.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(appointmentLockedRequest));
        }
    }
}