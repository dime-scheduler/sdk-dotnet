using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TaskFilterValueTests
    {
        [Fact]
        public async System.Threading.Tasks.Task TaskFilterValue()
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