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
            FilterGroup filterGroup = new()
            {
                Name = EntityNos.FilterGroup,
                ColumnNo = 1,
                DataFilter = true,
                Id = 1
            };

            FilterValue filterValue = new()
            {
                Group = EntityNos.FilterGroup,
                Value = EntityNos.FilterValue
            };

            Result groupResponse = await _dimeSchedulerClientFixture.Client.Filters.Groups.CreateAsync(filterGroup);
            Result valueResponse = await _dimeSchedulerClientFixture.Client.Filters.Values.CreateAsync(filterValue);
        }
    }
}