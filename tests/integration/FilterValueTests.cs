using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class FilterValueTests
    {
        [Fact]
        public void FilterValue_ToImportRequest_Append_AllShouldMapParameters()
        {
            FilterValue model = new()
            {
                Group = "GROUP",
                Value = "VALUE"
            };
        }
    }
}