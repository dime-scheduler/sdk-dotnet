using Dime.Scheduler.Entities;
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

        [Fact]
        public async System.Threading.Tasks.Task FilterValue()
        {
            FilterGroup filterGroup = new(EntityNos.FilterGroup);
            Result groupResponse = await _dimeSchedulerClientFixture.Client.Filters.Groups.CreateAsync(filterGroup);

            FilterValue filterValue = new(EntityNos.FilterGroup, EntityNos.FilterValue);
            Result valueResponse = await _dimeSchedulerClientFixture.Client.Filters.Values.CreateAsync(filterValue);
        }
    }
}