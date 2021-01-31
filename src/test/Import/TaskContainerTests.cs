using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class TaskContainerTests
    {
        [Fact]
        public void TaskContainer_Append_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            TaskContainer model = new TaskContainer { SourceApp = "BC001", SourceType = "BC001", JobNo = "JOB0001", TaskNo = "TASK0001", Name = "Container 1" };
            ImportRequest importRequest = (model as IImportRequestable).ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[0] == "SourceApp");
            Assert.True(importRequest.ParameterValues[0] == "BC001");
        }


        [Fact]
        public void TaskContainer_Append_Validate_HasIncompleteRequiredAttributes_ShouldThrowException()
        {
            TaskContainer model = new TaskContainer { SourceApp = "BC001" };
            Assert.Throws<Exception>(() => (model as IImportRequestable).ToImportRequest(TransactionType.Append));
        }

        [Fact]
        public void TaskContainer_Append_Validate_ExceedsMaxLength_ShouldThrowException()
        {
            TaskContainer model = new TaskContainer { SourceApp = "BC001", SourceType = "SOURCE TYPE LONGER THAN 10 CHARACTERS", JobNo = "JOB0001", TaskNo = "TASK0001", Name = "Container 1" };
            Assert.Throws<Exception>(() => (model as IImportRequestable).ToImportRequest(TransactionType.Append));
        }


        [Fact]
        public void TaskContainer_Delete_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            TaskContainer model = new TaskContainer { SourceApp = "BC001", SourceType = "BC001", JobNo = "JOB0001", TaskNo = "TASK0001" };
            ImportRequest importRequest = (model as IImportRequestable).ToImportRequest(TransactionType.Delete);

            Assert.True(importRequest.ParameterNames[0] == "SourceApp");
            Assert.True(importRequest.ParameterValues[0] == "BC001");
        }

        [Fact]
        public void TaskContainer_Delete_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            TaskContainer model = new TaskContainer();
            Assert.Throws<Exception>(() => (model as IImportRequestable).ToImportRequest(TransactionType.Delete));
        }
    }
}