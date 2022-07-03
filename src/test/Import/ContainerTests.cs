using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class ContainerTests
    {
        [Fact]
        public void Container_ToImportRequest_Append_AllShouldMapParameters()
        {
            Container model = new()
            {
                Name = "Container 1"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Container_Append_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            Container model = new()
            {
                Name = "Container 1",
                HandleDate = new DateTime(2021, 05, 25),
                HandleLocked = true
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[0] == "Name");
            Assert.True(importRequest.ParameterValues[0] == "Container 1");

            Assert.True(importRequest.ParameterNames[1] == "HandleDate");
            Assert.True(importRequest.ParameterValues[1] == "2021-05-25 00:00:00Z");

            Assert.True(importRequest.ParameterNames[2] == "HandleLocked");
            Assert.True(importRequest.ParameterValues[2] == "True");
        }

        [Fact]
        public void Container_Append_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            Container model = new();
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Append));
        }

        [Fact]
        public void Container_ToImportRequest_Delete_AllShouldMapParameters()
        {
            Container model = new()
            {
                Name = "Container 1",
                HandleDate = new DateTime(2021, 05, 25),
                HandleLocked = true
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Container_Delete_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            Container model = new();
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Delete));
        }
    }
}