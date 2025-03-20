using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentTimeMarkerTests
    {
        private static AppointmentTimeMarker CreateModel()
            => new()
            {
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                SourceApp = "APP",
                SourceType = "TYPE",
                TimeMarker = "TM"
            };

        [Fact]
        public void AppointmentTimeMarker()
        {
            AppointmentTimeMarker model = CreateModel();
        }
    }
}