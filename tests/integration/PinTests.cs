using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class PinTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public PinTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task Pin_ToImportRequest_Append_AllShouldMapParameters()
        {
            Pin model = new()
            {
                Color = "GREEN",
                Name = "PIN 1"
            };

            Result response = await _dimeSchedulerClientFixture.Client.Indicators.Pins.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}