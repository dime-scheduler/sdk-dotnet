using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ConnectorTests
    {
        [Fact]
        public async System.Threading.Tasks.Task Connector()
        {
            Connector model = new()
            {
                Name = "Connector 1"
            };
        }
    }
}