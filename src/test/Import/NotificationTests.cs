using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
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

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Notification_ToImportRequest_Delete_AllShouldMapParameters()
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
                Type = NotificationType.Warning
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Notification_ToImportRequest_InvalidTransactionType_ShouldThrowArgumentOutOfRangeException()
            => ToImportRequestTestUtils.TestToInvalidImportRequest<Notification>();
    }
}