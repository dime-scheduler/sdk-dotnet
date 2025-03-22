using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ImportTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public ImportTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task Import_ActionUri()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            ActionUri model = new()
            {
                SourceApp = "BC001",
                SourceType = "BC001",
                UriType = UriType.PlanningBoard,
                Uri = "https://www.google.com",
                Description = "Hello world",
                Default = true,
                RequestType = HttpRequestType.Get
            };

            ImportSet response = await _dimeSchedulerClientFixture.Client.Import.ProcessAsync(model, TransactionType.Append);
            Assert.True(response.Success, response.Message);
        }
    }
}