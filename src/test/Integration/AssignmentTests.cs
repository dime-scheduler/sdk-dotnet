using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class AssignmentTests
    {
        [Fact]
        public async t.Task Assignment_Append_ShouldCreateAppointment()
        {
            ImportRequest appointmentBaseRequest = AppointmentTests.Test.ToImportRequest(TransactionType.Append);
            long appointment = await DimeScheduler.DoAppointmentImportRequest(appointmentBaseRequest);

            Assignment assignment = new()
            {
                AppointmentId = appointment,
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                ResourceNo = "Hendrik (Mobile)"
            };

            ImportRequest assignmentRequest = assignment.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(assignmentRequest));
        }
    }
}