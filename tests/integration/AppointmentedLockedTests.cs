using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentLockedTests
    {
        [Fact]
        public async System.Threading.Tasks.Task AppointmentLocked()
        {
            AppointmentLocked model = new()
            {
                SourceApp = "BC001",
                SourceType = "BC001",
                AppointmentId = 1,
                AppointmentGuid = Guid.NewGuid(),
                Locked = true,
                SentFromBackOffice = true
            };
        }
    }
}