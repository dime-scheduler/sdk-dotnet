using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TaskLockedTests
    {
        [Fact]
        public void TaskLocked()
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