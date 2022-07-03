using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class AppointmentImportanceTests
    {
        [Fact]
        public async t.Task AppointmentImportance_Append_ShouldCreateAppointment()
        {
            ImportRequest appointmentBaseRequest = AppointmentTests.Test.ToImportRequest(TransactionType.Append);
            long appointment = await DimeScheduler.DoAppointmentImportRequest(appointmentBaseRequest);

            AppointmentImportance appointmentImportance = new()
            {
                AppointmentId = appointment,
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                Importance = Importance.Low
            };

            ImportRequest appointmentImportanceRequest = appointmentImportance.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(appointmentImportanceRequest));
        }
    }
}