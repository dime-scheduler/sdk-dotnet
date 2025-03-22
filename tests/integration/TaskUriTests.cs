using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TaskUriTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public TaskUriTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task TaskUri()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            TaskUri model = new()
            {
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                JobNo = EntityNos.Job,
                TaskNo = EntityNos.Task,
                Description = "DESC",
                Uri = "https://www.dimescheduler.com"
            };

            Result response = await _dimeSchedulerClientFixture.Client.Tasks.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}