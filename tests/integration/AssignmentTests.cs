using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AssignmentTests
    {
        [Fact]
        public void Assignment()
        {
            Assignment model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                ResourceNo = "LINDA",
                SentFromBackOffice = true,
                AppointmentGuid = new System.Guid(),
                AppointmentId = 1
            };
        }
    }
}