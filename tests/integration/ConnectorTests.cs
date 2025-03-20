using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ConnectorTests
    {
        [Fact]
        public void Connector()
        {
            Connector model = new()
            {
                Name = "Connector 1"
            };
        }
    }
}