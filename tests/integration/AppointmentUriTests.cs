using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentUriTests
    {
        [Fact]
        public void AppointmentUri()
        {
            AppointmentUri model = new()
            {
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SourceApp = "APP",
                SourceType = "TYPE",
                Description = "DESC",
                Uri = "URI"
            };
        }
    }
}