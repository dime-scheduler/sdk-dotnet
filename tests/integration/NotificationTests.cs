using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class NotificationTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public NotificationTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task Notification_ToImportRequest_Append_AllShouldMapParameters()
        {
            Notification model = new()
            {
                SentFromBackOffice = true,
                Code = "CODE",
                Date = new DateTime(2020, 1, 1),
                SourceApp = "APP",              
                SourceType = "TYPE",
                Text = "TXT",
                Type = NotificationType.Error
            };

            Result response = await _dimeSchedulerClientFixture.Client.Notifications.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}