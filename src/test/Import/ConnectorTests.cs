using System;
using Dime.Scheduler.Sdk.Models;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class ConnectorTests
    {
        [Fact]
        public void Connector_ToImportRequest_Append_AllShouldMapParameters()
        {
            Connector model = new()
            {
                Name = "Connector 1"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Connector_Append_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            Connector model = new()
            {
                Name = "Connector 1"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[0] == "Name");
            Assert.True(importRequest.ParameterValues[0] == "Connector 1");
        }

        [Fact]
        public void Connector_Append_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            Connector model = new();
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Append));
        }

        [Fact]
        public void Connector_ToImportRequest_Delete_AllShouldMapParameters()
        {
            Connector model = new()
            {
                Name = "Connector 1"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}