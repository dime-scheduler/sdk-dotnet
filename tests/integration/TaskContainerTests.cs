using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TaskContainerTests
    {
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
                TaskNo = "TEXT"
            };
        }
    }
}