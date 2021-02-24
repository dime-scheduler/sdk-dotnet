using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class AppointmentCategoryTests
    {
        [Fact]
        public void AppointmentCategory_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentCategory model = new()
            {
                SourceType = "TYPE",
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                Category = "CAT",
                SentFromBackOffice = true,
                SourceApp = "APP"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}