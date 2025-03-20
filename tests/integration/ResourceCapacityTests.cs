using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceCapacityTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public ResourceCapacityTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task ResourceCapacity_ToImportRequest_Append_AllShouldMapParameters()
        {
            ResourceCapacity model = new()
            {
                ResourceNo = EntityNos.Resource,
                CapacityInSeconds = 1,
                Date = new DateTime(2020, 1, 1),
                Quantity = 1,
                UnitOfMeasure = "YES",
                UnitOfMeasureConversion = 1
            };

            Result response = await _dimeSchedulerClientFixture.Client.Resources.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}