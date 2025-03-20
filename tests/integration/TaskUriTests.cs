using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TaskUriTests
    {
        [Fact]
        public async System.Threading.Tasks.Task TaskUri()
        {
            TaskUri model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                Description = "DESC",
                Uri = "URI",
                JobNo = "JOB001",
                TaskNo = "TASK001"
            };
        }       
    }
}