using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TaskContainerTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public TaskContainerTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task TaskContainer()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            TaskContainer model = new()
            {
                Index = 1,
                JobNo = EntityNos.Job,
                Name = "TEXT",
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                TaskNo = EntityNos.Task
            };

            Result response = await _dimeSchedulerClientFixture.Client.Tasks.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}