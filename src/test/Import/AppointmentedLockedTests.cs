using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class AppointmentLockedTests
    {
        [Fact]
        public void AppointmentLocked_ToImportRequest_Append_AllShouldMapParameters()
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

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);

            importRequest.AssertStoredProcedureName("mboc_updateAppointmentLocked");
            importRequest.AssertEqualParameterCollectionCount();
            importRequest.AssertParameterCount(6);
        }

        [Fact]
        public void AppointmentLocked_ToImportRequest_Delete_ShouldThrowException()
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

            model.ShouldNotCreateImportRequest(TransactionType.Delete);
        }

        [Fact]
        public void AppointmentLocked_ToImportRequest_InvalidTransactionType_ShouldThrowArgumentOutOfRangeException()
            => ToImportRequestTestUtils.TestToInvalidImportRequest<AppointmentLocked>();
    }
}