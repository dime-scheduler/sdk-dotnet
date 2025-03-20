using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class CategoryTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public CategoryTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task Category()
        {
            Category model = new()
            {
                Name = "CATEGORY_1",
                DisplayName = "Category 1",
                Color = "BLUE"
            };

            Result response = await _dimeSchedulerClientFixture.Client.Indicators.Categories.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}