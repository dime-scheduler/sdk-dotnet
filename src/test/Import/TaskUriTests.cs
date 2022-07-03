using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class TaskUriTests
    {
        [Fact]
        public void TaskUri_ToImportRequest_Append_AllShouldMapParameters()
        {
            TaskUri model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                Description = "DESC",
                Uri = "URI",
                JobNo = "JOB001",
                TaskNo = "TASK001"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void TaskUri_ToImportRequest_Delete_ShouldThrowException()
        {
            TaskUri model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                Description = "DESC",
                Uri = "URI",
                JobNo = "JOB001",
                TaskNo = "TASK001"
            };

            Assert.Throws<NotImplementedException>(() => model.ToImportRequest(TransactionType.Delete));
        }
    }
}