using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class TaskUriTests
    {
        [Fact]
        public async t.Task TaskUri_Append_ShouldCreateAppointment()
        {
            // Ensure task exists
            ImportRequest taskBaseRequest = TaskTests.Test.ToImportRequest(TransactionType.Append);
            await DimeScheduler.DoImportRequest(taskBaseRequest);

            TaskUri taskUri = new()
            {
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                JobNo = TaskTests.Test.JobNo,
                TaskNo = TaskTests.Test.TaskNo,
                Uri = "https://www.google.com",
                Description = "Send message to customer"
            };

            ImportRequest taskUriRequest = taskUri.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(taskUriRequest));
        }
    }
}