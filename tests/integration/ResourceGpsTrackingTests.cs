using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceGpsTrackingTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public ResourceGpsTrackingTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task ResourceGpsTracking()
        {
            decimal lat1 = 31.733256M;
            decimal lng1 = -3.698385M;

            decimal lat2 = 36.780783M;
            decimal lng2 = -2.241639M;

            Random r = new();
            int rInt = r.Next(0, 2);

            ResourceGpsTracking model = new()
            {
                ResourceNo = "120",
                Latitude = rInt == 0 ? lat1 : lat2,
                Longitude = rInt == 0 ? lng1 : lng2
            };

            Result response = await _dimeSchedulerClientFixture.Client.Resources.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}