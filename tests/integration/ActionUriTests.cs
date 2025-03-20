using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ActionUriTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public ActionUriTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task ActionUri()
        {
            ActionUri model = new()
            {
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                UriType = UriType.PlanningBoard,
                Uri = "https://www.google.com",
                Description = "Hello world",
                Default = true,
                RequestType = HttpRequestType.Get
            };

            Result response = await _dimeSchedulerClientFixture.Client.ActionUris.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}