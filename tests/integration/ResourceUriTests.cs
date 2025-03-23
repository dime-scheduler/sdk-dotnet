using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceUriTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public ResourceUriTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task ResourceUri()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            ResourceUri model = new()
            {
                Description = "TEXT",
                ResourceNo = EntityNos.Resource,
                Uri = "TEXT"
            };

            Result response = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Resources.CreateAsync(model));
            Assert.True(response.IsSuccess, response.Error?.ToString());
        }
    }
}