using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class PinTests
    {
        [Fact]
        public void Pin_Append_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            Pin model = new() { Name = "Pin 1" };
            ImportRequest importRequest = ((IImportRequestable) model).ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[0] == "Name");
            Assert.True(importRequest.ParameterValues[0] == "Pin 1");
        }

        [Fact]
        public void Pin_Append_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            Pin model = new();
            Assert.Throws<Exception>(() => ((IImportRequestable) model).ToImportRequest(TransactionType.Append));
        }

        [Fact]
        public void Pin_Delete_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            Pin model = new();
            Assert.Throws<Exception>(() => ((IImportRequestable) model).ToImportRequest(TransactionType.Delete));
        }
    }
}