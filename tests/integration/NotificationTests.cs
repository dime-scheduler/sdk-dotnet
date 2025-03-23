using System;
using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
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

        [SkippableFact]
        public async System.Threading.Tasks.Task Notification_ToImportRequest_Append_AllShouldMapParameters()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

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

            Result response = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Notifications.CreateAsync(model));
            Assert.True(response.IsSuccess, response.Error?.ToString());
        }
    }
}