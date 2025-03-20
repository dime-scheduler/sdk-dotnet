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
                Name = "Group #1",
                ColumnNo = 1,
                DataFilter = true,
                Id = 1
            };

            FilterValue filterValue = new()
            {
                Group = "Group #1",
                Value = "Value #1"
            };

            Result groupResponse = await _dimeSchedulerClientFixture.Client.Filters.Groups.CreateAsync(filterGroup);
            Result valueResponse = await _dimeSchedulerClientFixture.Client.Filters.Values.CreateAsync(filterValue);
        }
    }
}