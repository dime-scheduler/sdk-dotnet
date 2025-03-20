using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ContainerTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public ContainerTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task Container()
        {
            Container model = new()
            {
                Name = EntityNos.Container
            };

            Result response = await _dimeSchedulerClientFixture.Client.Containers.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}