using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
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

        [SkippableFact]
        public async System.Threading.Tasks.Task TaskLocked()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            TaskLocked model = new()
            {
                SentFromBackOffice = true,
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                JobNo = EntityNos.Job,
                TaskNo = EntityNos.Task,
                Locked = true
            };

            Result response = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Tasks.CreateAsync(model));
            Assert.True(response.IsSuccess, response.Error?.ToString());
        }
    }
}