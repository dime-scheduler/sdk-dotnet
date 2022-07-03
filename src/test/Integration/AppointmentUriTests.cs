using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class AppointmentUriTests
    {
        [Fact]
        public async t.Task AppointmentUri_Append_ShouldCreateAppointment()
        {
            ImportRequest appointmentBaseRequest = AppointmentTests.Test.ToImportRequest(TransactionType.Append);
            long appointment = await DimeScheduler.DoAppointmentImportRequest(appointmentBaseRequest);

            AppointmentUri appointmentUri = new()
            {
                AppointmentId = appointment,
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                Uri = "Finished",
                Description = "Call technician"
            };

            ImportRequest appointmentUriRequest = appointmentUri.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(appointmentUriRequest));
        }
    }
}