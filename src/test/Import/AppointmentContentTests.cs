using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class AppointmentContentTests
    {
        private static AppointmentContent CreateModel()
            => new()
            {
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                SourceApp = "APP",
                SourceType = "TYPE",
                Subject = "Subject",
                Body = "Body"
            };

        [Fact]
        public void AppointmentContent_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentContent model = CreateModel();

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void AppointmentContent_ToImportRequest_Delete_ShouldThrowException()
        {
            AppointmentContent model = CreateModel();

            model.ShouldNotCreateImportRequest(TransactionType.Delete);
        }
    }
}