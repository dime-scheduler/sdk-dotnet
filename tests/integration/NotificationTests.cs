using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class NotificationTests
    {
        [Fact]
        public void Notification_ToImportRequest_Append_AllShouldMapParameters()
        {
            Notification model = new()
            {
                SentFromBackOffice = true,
                AppointmentId = 1,
                AppointmentGuid = Guid.NewGuid(),
                Code = "CODE",
                Date = new DateTime(2020, 1, 1),
                JobNo = "JOB",
                ConnectorId = "MBOC",
                SourceApp = "APP",
                TaskNo = "TASK",
                SourceType = "TYPE",
                Text = "TXT",
                Type = NotificationType.Error
            };
        }
    }
}