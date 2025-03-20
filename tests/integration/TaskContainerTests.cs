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

        [Fact]
        public async System.Threading.Tasks.Task TaskContainer()
        {
            TaskContainer model = new()
            {
                Index = 1,
                JobNo = "TEXT",
                Name = "TEXT",
                SourceApp = "TEXT",
                SourceType = "TEXT",
                TaskNo = EntityNos.Task
            };

            Result response = await _dimeSchedulerClientFixture.Client.Tasks.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}