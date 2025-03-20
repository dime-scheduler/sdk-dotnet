using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class PinTests
    {
        [Fact]
        public async System.Threading.Tasks.Task Pin_ToImportRequest_Append_AllShouldMapParameters()
        {
            Pin model = new()
            {
                Color = "GREEN",
                Name = "PIN 1"
            };
        }
    }
}