using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentContentTests
    {
        private static AppointmentContent CreateModel()
            => new()
            {
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                SourceApp = "APP",
                SourceType = "TYPE",
                Subject = "Subject",
                Body = "Body"
            };

        [Fact]
        public async System.Threading.Tasks.Task AppointmentContent()
        {
            AppointmentContent model = CreateModel();
        }
    }
}