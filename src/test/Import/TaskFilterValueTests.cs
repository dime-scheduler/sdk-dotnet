using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class TaskFilterValueTests
    {
        [Fact]
        public void TaskFilterValue_ToImportRequest_Append_AllShouldMapParameters()
        {
            TaskFilterValue model = new()
            {
                FilterValue = "TEXT",
                TransferToTemp = true,
                JobNo = "TEXT",
                SourceApp = "TEXT",
                SourceType = "TEXT",
                TaskNo = "TEXT",
                FilterGroup = "TEXT"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void TaskFilterValue_ToImportRequest_Delete_AllShouldMapParameters()
        {
            TaskFilterValue model = new()
            {
                FilterValue = "TEXT",
                TransferToTemp = true,
                JobNo = "TEXT",
                SourceApp = "TEXT",
                SourceType = "TEXT",
                TaskNo = "TEXT",
                FilterGroup = "TEXT"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}