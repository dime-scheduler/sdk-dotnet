using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TaskFilterValueTests
    {
        [Fact]
        public void TaskFilterValue()
        {
            TaskFilterValue model = new()
            {
                FilterValue = "TEXT",
                TransferToTemp = true,
                JobNo = "TEXT",
                SourceApp = "TEXT",
                SourceType = "TEXT",
                TaskNo = "TEXT",
                FilterGroup = "TEXT"
            };
        }
    }
}