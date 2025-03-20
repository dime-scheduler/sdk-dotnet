using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TaskLockedTests
    {
        [Fact]
        public async System.Threading.Tasks.Task TaskLocked()
        {
            TaskLocked model = new()
            {
                SentFromBackOffice = true,
                JobNo = "TEXT",
                SourceApp = "TEXT",
                SourceType = "TEXT",
                TaskNo = "TEXT",
                Locked = true
            };
        }
    }
}