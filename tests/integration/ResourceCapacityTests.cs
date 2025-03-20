using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceCapacityTests
    {
        [Fact]
        public async System.Threading.Tasks.Task ResourceCapacity_ToImportRequest_Append_AllShouldMapParameters()
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
        }
    }
}