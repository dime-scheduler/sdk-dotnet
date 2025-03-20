using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentCategoryTests
    {
        private static AppointmentCategory CreateModel()
            => new()
            {
                SourceType = "TYPE",
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                Category = "CAT",
                SentFromBackOffice = true,
                SourceApp = "APP"
            };

        [Fact]
        public void AppointmentCategory()
        {
            AppointmentCategory model = CreateModel();
        }
    }
}