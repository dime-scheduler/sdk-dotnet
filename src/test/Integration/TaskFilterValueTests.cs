using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class TaskFilterValueTests
    {
        [Fact]
        public async t.Task TaskFilterValue_Append_ShouldCreateAppointment()
        {
            // Ensure task exists
            ImportRequest taskBaseRequest = TaskTests.Test.ToImportRequest(TransactionType.Append);
            await DimeScheduler.DoImportRequest(taskBaseRequest);

            // Ensure filter group and value exist
            FilterGroup filterGroup = new() { Name = "Certifications" };
            ImportRequest fgRequest = filterGroup.ToImportRequest(TransactionType.Append);
            await DimeScheduler.DoImportRequest(fgRequest);

            FilterValue filterValue = new() { Group = "Certifications", Value = "Forklift level A" };
            ImportRequest fvRequest = filterValue.ToImportRequest(TransactionType.Append);
            await DimeScheduler.DoImportRequest(fvRequest);

            TaskFilterValue taskFilterValue = new()
            {
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                JobNo = TaskTests.Test.JobNo,
                TaskNo = TaskTests.Test.TaskNo,
                FilterGroup = filterGroup.Name,
                FilterValue = filterValue.Value
            };

            ImportRequest taskFilterValueRequest = taskFilterValue.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(taskFilterValueRequest));
        }
    }
}