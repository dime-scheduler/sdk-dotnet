using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class AppointmentCategoryTests
    {
        [Fact]
        public async t.Task AppointmentCategory_Append_ShouldCreateAppointment()
        {
            ImportRequest appointmentBaseRequest = AppointmentTests.Test.ToImportRequest(TransactionType.Append);
            long appointment = await DimeScheduler.DoAppointmentImportRequest(appointmentBaseRequest);

            AppointmentCategory appointmentCategory = new()
            {
                AppointmentId = appointment,
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                Category = "Personal day"
            };

            ImportRequest appointmentCategoryRequest = appointmentCategory.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(appointmentCategoryRequest));
        }
    }
}