using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class AppointmentUriTests
    {
        [Fact]
        public void AppointmentUri_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentUri model = new()
            {
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SourceApp = "APP",
                SourceType = "TYPE",
                Description = "DESC",
                Uri = "URI"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}