using System;
using Dime.Scheduler.Sdk.Models;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class AppointmentImportanceTests
    {
        private static AppointmentImportance CreateModel()
            => new()
            {
                SourceType = "TYPE",
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                SourceApp = "APP",
                Importance = Importance.Medium
            };

        [Fact]
        public void AppointmentImportance_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentImportance model = CreateModel();

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void AppointmentImportance_ToImportRequest_Delete_ShouldThrowException()
        {
            AppointmentImportance model = CreateModel();
            model.ShouldNotCreateImportRequest(TransactionType.Delete);
        }
    }
}