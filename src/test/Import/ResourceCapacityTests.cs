using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class ResourceCapacityTests
    {
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