using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class FilterValueTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public FilterValueTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task FilterValue()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            FilterGroup filterGroup = new(EntityNos.FilterGroup);
            Result groupResponse = await _dimeSchedulerClientFixture.Client.Filters.Groups.CreateAsync(filterGroup);

            FilterValue filterValue = new(EntityNos.FilterGroup, EntityNos.FilterValue);
            Result valueResponse = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Filters.Values.CreateAsync(filterValue));
            Assert.True(valueResponse.IsSuccess, valueResponse.Error?.Message);
        }
    }
}