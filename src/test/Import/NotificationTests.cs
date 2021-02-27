using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class NotificationTests
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
                Type = "TYPE"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}