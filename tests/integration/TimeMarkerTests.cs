using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TimeMarkerTests
    {
        [Fact]
        public async System.Threading.Tasks.Task TimeMarker()
        {
            TimeMarker model = new()
            {
                Name = "MARKER 1",
                Color = "BLUE"
            };
        }
    }
}