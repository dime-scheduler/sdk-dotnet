using System;
using Dime.Scheduler.Sdk.Models;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class PinTests
    {
        [Fact]
        public void Pin_ToImportRequest_Append_AllShouldMapParameters()
        {
            Pin model = new()
            {
                Color = "GREEN",
                Name = "PIN 1"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Pin_Append_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            Pin model = new() { Name = "Pin 1" };
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[0] == "Name");
            Assert.True(importRequest.ParameterValues[0] == "Pin 1");
        }

        [Fact]
        public void Pin_Append_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            Pin model = new();
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Append));
        }

        [Fact]
        public void Pin_ToImportRequest_Delete_AllShouldMapParameters()
        {
            Pin model = new("Hello world", "Blue");
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Pin_Delete_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            Pin model = new();
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Delete));
        }
    }
}