using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class AppointmentTimeMarkerTests
    {
        [Fact]
        public async t.Task AppointmentTimeMarker_Append_ShouldCreateAppointment()
        {
            ImportRequest appointmentBaseRequest = AppointmentTests.Test.ToImportRequest(TransactionType.Append);
            long appointment = await DimeScheduler.DoAppointmentImportRequest(appointmentBaseRequest);

            AppointmentTimeMarker appointmentTimeMarker = new()
            {
                AppointmentId = appointment,
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                TimeMarker = "Finished"
            };

            ImportRequest appointmentTimeMarkerRequest = appointmentTimeMarker.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(appointmentTimeMarkerRequest));
        }
    }
}