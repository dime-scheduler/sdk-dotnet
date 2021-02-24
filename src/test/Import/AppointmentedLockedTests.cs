using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class AppointmentLockedTests
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

            importRequest.AssertStoredProcedureName("mboc_upsertAppointmentLocked");
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
    }
}