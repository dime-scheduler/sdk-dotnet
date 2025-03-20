using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class CategoryTests
    {
        [Fact]
        public void Category()
        {
            Category model = new()
            {
                Name = "CATEGORY_1",
                DisplayName = "Category 1",
                Color = "BLUE"
            };
        }
    }
}