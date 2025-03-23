using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
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

        [SkippableFact]
        public async System.Threading.Tasks.Task ActionUri()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

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

            Result response = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.ActionUris.CreateAsync(model));
            Assert.True(response.IsSuccess, response.Error?.ToString());
        }
    }
}