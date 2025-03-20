using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceUriTests
    {
        [Fact]
        public void ResourceUri()
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