using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ConnectorTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public ConnectorTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task Connector()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            Connector model = new()
            {
                Name = "Connector 1",
                SourceApp = EntityNos.SourceApp,
                Uri = "https://www.dimescheduler.com/"
            };

            Result response = await _dimeSchedulerClientFixture.Client.Connectors.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}