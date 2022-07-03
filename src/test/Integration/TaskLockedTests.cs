using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class TaskLockedTests
    {
        [Fact]
        public async t.Task TaskLocked_Append_ShouldCreateAppointment()
        {
            // Ensure task exists
            ImportRequest taskBaseRequest = TaskTests.Test.ToImportRequest(TransactionType.Append);
            await DimeScheduler.DoImportRequest(taskBaseRequest);

            TaskLocked taskLocked = new()
            {
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                TaskNo = TaskTests.Test.TaskNo,
                Locked = true
            };

            ImportRequest taskLockedRequest = taskLocked.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(taskLockedRequest));
        }
    }
}