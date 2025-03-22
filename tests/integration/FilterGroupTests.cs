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

        [SkippableFact]
        public async System.Threading.Tasks.Task FilterGroup()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            FilterGroup model = new() { Name = EntityNos.FilterGroup };

            Result response = await _dimeSchedulerClientFixture.Client.Filters.Groups.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}