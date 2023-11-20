using Dime.Scheduler.Sdk.Models;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class TaskFilterValueTests
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

        [Fact]
        public void TaskFilterValue_ToImportRequest_InvalidTransactionType_ShouldThrowArgumentOutOfRangeException()
            => ToImportRequestTestUtils.TestToInvalidImportRequest<TaskFilterValue>();

        [Fact]
        public void TaskFilterValue_ToImportRequest_Clear_AllShouldMapParameters()
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

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete, true);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}