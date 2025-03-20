using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class FilterGroupTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public FilterGroupTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task FilterGroup()
        {
            FilterGroup model = new()
            {
                Name = EntityNos.FilterGroup,
                ColumnNo = 1,
                DataFilter = true,
                Id = 1
            };

            Result response = await _dimeSchedulerClientFixture.Client.Filters.Groups.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}