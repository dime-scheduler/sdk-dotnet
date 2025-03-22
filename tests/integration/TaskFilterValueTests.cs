using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TaskFilterValueTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public TaskFilterValueTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task TaskFilterValue()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            TaskFilterValue model = new()
            {
                TransferToTemp = true,
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                JobNo = EntityNos.Job,
                TaskNo = EntityNos.Task,
                FilterGroup = EntityNos.FilterGroup,
                FilterValue = EntityNos.FilterValue
            };

            Result response = await _dimeSchedulerClientFixture.Client.Tasks.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}