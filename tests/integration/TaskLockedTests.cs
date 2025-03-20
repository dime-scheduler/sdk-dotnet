using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TaskLockedTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public TaskLockedTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task TaskLocked()
        {
            TaskLocked model = new()
            {
                SentFromBackOffice = true,
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                JobNo = EntityNos.Job,
                TaskNo = EntityNos.Task,
                Locked = true
            };

            Result response = await _dimeSchedulerClientFixture.Client.Tasks.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}