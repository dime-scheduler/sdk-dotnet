using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentImportanceTests
    {
        private static AppointmentImportance CreateModel()
            => new()
            {
                SourceType = "TYPE",
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                SourceApp = "APP",
                Importance = Importance.Medium
            };

        [Fact]
        public async System.Threading.Tasks.Task AppointmentImportance()
        {
            AppointmentImportance model = CreateModel();
        }
    }
}