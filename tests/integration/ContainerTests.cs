using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ContainerTests
    {
        [Fact]
        public async System.Threading.Tasks.Task Container()
        {
            Container model = new()
            {
                Name = "Container 1"
            };
        }
    }
}