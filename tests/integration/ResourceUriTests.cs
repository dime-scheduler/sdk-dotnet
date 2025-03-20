using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceUriTests
    {
        [Fact]
        public async System.Threading.Tasks.Task ResourceUri()
        {
            ResourceUri model = new()
            {
                Description = "TEXT",
                ResourceNo = "TEXT",
                Uri = "TEXT"
            };
        }
    }
}