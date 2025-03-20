using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class AppointmentCategoryTests
    {
        private static AppointmentCategory CreateModel()
            => new()
            {
                SourceType = "TYPE",
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                Category = "CAT",
                SentFromBackOffice = true,
                SourceApp = "APP"
            };

        [Fact]
        public void AppointmentCategory_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentCategory model = CreateModel();

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void AppointmentCategory_ToImportRequest_Delete_ShouldThrowException()
        {
            AppointmentCategory model = CreateModel();

            model.ShouldNotCreateImportRequest(TransactionType.Delete);
        }
    }
}