using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class TaskContainerTests
    {
        [Fact]
        public void TaskContainer_ToImportRequest_Append_AllShouldMapParameters()
        {
            TaskContainer model = new()
            {
                Index = 1,
                JobNo = "TEXT",
                Name = "TEXT",
                SourceApp = "TEXT",
                SourceType = "TEXT",
                TaskNo = "TEXT"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void TaskContainer_Append_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            TaskContainer model = new() { SourceApp = "BC001", SourceType = "BC001", JobNo = "JOB0001", TaskNo = "TASK0001", Name = "Container 1" };
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[0] == "SourceApp");
            Assert.True(importRequest.ParameterValues[0] == "BC001");
        }

        [Fact]
        public void TaskContainer_Append_Validate_HasIncompleteRequiredAttributes_ShouldThrowException()
        {
            TaskContainer model = new() { SourceApp = "BC001" };
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Append));
        }

        [Fact]
        public void TaskContainer_Append_Validate_ExceedsMaxLength_ShouldThrowException()
        {
            TaskContainer model = new() { SourceApp = "BC001", SourceType = "SOURCE TYPE LONGER THAN 10 CHARACTERS", JobNo = "JOB0001", TaskNo = "TASK0001", Name = "Container 1" };
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Append));
        }

        [Fact]
        public void TaskContainer_Delete_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            TaskContainer model = new() { SourceApp = "BC001", SourceType = "BC001", JobNo = "JOB0001", TaskNo = "TASK0001", Name = "HELLO" };
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);

            Assert.True(importRequest.ParameterNames[0] == "SourceApp");
            Assert.True(importRequest.ParameterValues[0] == "BC001");
        }

        [Fact]
        public void TaskContainer_Delete_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            TaskContainer model = new();
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Delete));
        }

        [Fact]
        public void TaskContainer_ToImportRequest_InvalidTransactionType_ShouldThrowArgumentOutOfRangeException()
            => ToImportRequestTestUtils.TestToInvalidImportRequest<TaskContainer>();
    }
}