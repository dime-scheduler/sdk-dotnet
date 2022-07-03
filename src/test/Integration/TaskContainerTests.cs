using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class TaskContainerTests
    {
        [Fact]
        public async t.Task TaskContainer_Append_ShouldCreateAppointment()
        {
            // Ensure task exists
            ImportRequest taskBaseRequest = TaskTests.Test.ToImportRequest(TransactionType.Append);
            await DimeScheduler.DoImportRequest(taskBaseRequest);

            TaskContainer taskContainer = new()
            {
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                TaskNo = TaskTests.Test.TaskNo,
                Name = ContainerTests.Test.Name
            };

            ImportRequest taskContainerRequest = taskContainer.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(taskContainerRequest));
        }
    }
}