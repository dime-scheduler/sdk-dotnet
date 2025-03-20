using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceFilterValueTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public ResourceFilterValueTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task ResourceFilterValue()
        {
            ResourceFilterValue model = new()
            {
                FilterGroup = EntityNos.FilterGroup,
                FilterValue = EntityNos.FilterValue,
                ResourceNo = EntityNos.Resource,
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                TransferToTemp = true
            };

            Result response = await _dimeSchedulerClientFixture.Client.Resources.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}