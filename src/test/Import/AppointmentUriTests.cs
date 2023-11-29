using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class AppointmentUriTests
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

        [Fact]
        public void AppointmentUri_ToImportRequest_Delete_ShouldThrowException()
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

            Assert.Throws<NotImplementedException>(() => model.ToImportRequest(TransactionType.Delete));
        }
    }
}