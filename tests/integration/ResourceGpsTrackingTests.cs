using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceGpsTrackingTests
    {
        [Fact]
        public async System.Threading.Tasks.Task ResourceGpsTracking()
        {
            decimal lat1 = 36.733256M;
            decimal lng1 = -3.698385M;

            decimal lat2 = 36.780783M;
            decimal lng2 = -2.241639M;

            Random r = new();
            int rInt = r.Next(0, 2);

            ResourceGpsTracking model = new()
            {
                Date = new DateTime(2020, 1, 1),
                ResourceNo = "LINA",
                GpsTrackingResourceNo = "NO",
                Latitude = rInt == 0 ? lat1 : lat2,
                Longitude = rInt == 0 ? lng1 : lng2,
                Power = "MAX",
                RowId = "1",
                Speed = 1
            };
        }
    }
}