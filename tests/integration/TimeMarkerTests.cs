using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TimeMarkerTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public TimeMarkerTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task TimeMarker()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            TimeMarker model = new()
            {
                Name = "MARKER 1",
                Color = "BLUE"
            };

            Result response = await _dimeSchedulerClientFixture.Client.Indicators.TimeMarkers.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}