using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class AppointmentFieldValueTests
    {
        private static AppointmentFieldValue CreateModel()
            => new()
            {
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                SourceApp = "APP",
                SourceType = "TYPE",
                FieldCode = "ISCOMPLETE",
                FieldValue = "true"
            };

        [Fact]
        public void AppointmentFieldValue_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentFieldValue model = CreateModel();

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void AppointmentFieldValue_ToImportRequest_Delete_ShouldThrowException()
        {
            AppointmentFieldValue model = CreateModel();

            model.ShouldNotCreateImportRequest(TransactionType.Delete);
        }
    }
}