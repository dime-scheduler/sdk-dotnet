using System;
using Dime.Scheduler.Sdk.Models;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class AppointmentTimeMarkerTests
    {
        private static AppointmentTimeMarker CreateModel()
            => new()
            {
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                SourceApp = "APP",
                SourceType = "TYPE",
                TimeMarker = "TM"
            };

        [Fact]
        public void AppointmentTimeMarker_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentTimeMarker model = CreateModel();

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void AppointmentTimeMarker_ToImportRequest_Delete_ShouldThrowException()
        {
            AppointmentTimeMarker model = CreateModel();

            model.ShouldNotCreateImportRequest(TransactionType.Delete);
        }
    }
}