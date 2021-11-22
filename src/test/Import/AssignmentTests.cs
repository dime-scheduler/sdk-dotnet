using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class AssignmentTests
    {
        [Fact]
        public void Assignment_ToImportRequest_Append_AllShouldMapParameters()
        {
            Assignment model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                ResourceNo = "LINDA",
                SentFromBackOffice = true,
                AppointmentGuid = new System.Guid(),
                AppointmentId = 1
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Assignment_ToImportRequest_Delete_AllShouldMapParameters()
        {
            Assignment model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                ResourceNo = "LINDA",
                SentFromBackOffice = true,
                AppointmentGuid = System.Guid.NewGuid(),
                AppointmentId = 1
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}