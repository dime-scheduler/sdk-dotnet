using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class FilterGroupTests
    {
        [Fact]
        public void FilterGroup_ToImportRequest_Append_AllShouldMapParameters()
        {
            FilterGroup model = new()
            {
                Name = "Name",
                ColumnNo = 1,
                DataFilter = true,
                Id = 1
            };
        }
    }
}