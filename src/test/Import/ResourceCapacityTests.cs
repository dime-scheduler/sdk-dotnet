using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class ResourceCapacityTests
    {
        [Fact]
        public void ResourceCapacity_ToImportRequest_Append_AllShouldMapParameters()
        {
            ResourceCapacity model = new()
            {
                ResourceNo = "RESOURCE1",
                CapacityInSeconds = 1,
                Date = new DateTime(2020, 1, 1),
                Quantity = 1,
                UnitOfMeasure = "YES",
                UnitOfMeasureConversion = 1
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void ResourceCapacity_ToImportRequest_Delete_AllShouldMapParameters()
        {
            ResourceCapacity model = new()
            {
                ResourceNo = "RESOURCE1",
                CapacityInSeconds = 1,
                Date = new DateTime(2020, 1, 1),
                Quantity = 1,
                UnitOfMeasure = "YES",
                UnitOfMeasureConversion = 1
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void ResourceCapacity_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            ResourceCapacity model = new() { ResourceNo = "HJONES" };
            ImportRequest importRequest = (model as IImportRequestable).ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[0] == "ResourceNo");
            Assert.True(importRequest.ParameterValues[0] == "HJONES");
        }

        [Fact]
        public void ResourceCapacity_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            ResourceCapacity model = new();
            Assert.Throws<Exception>(() => (model as IImportRequestable).ToImportRequest(TransactionType.Append));
        }
    }
}