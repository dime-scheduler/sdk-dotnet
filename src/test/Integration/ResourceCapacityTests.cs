using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class ResourceCapacityTests
    {
        [Fact]
        public async t.Task ResourceCapacity_Append_ShouldCreateAppointment()
        {
            // Ensure resource exists
            ImportRequest resourceBaseRequest = ResourceTests.Test.ToImportRequest(TransactionType.Append);
            await DimeScheduler.DoImportRequest(resourceBaseRequest);

            ResourceCapacity resourceCapacity = new()
            {
                ResourceNo = ResourceTests.Test.ResourceNo,
                Quantity = 8,
                Date = DateTime.Now
            };

            ImportRequest resourceCapacityRequest = resourceCapacity.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(resourceCapacityRequest));
        }
    }
}