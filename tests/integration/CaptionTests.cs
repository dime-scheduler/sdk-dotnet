using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class CaptionTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public CaptionTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task Captions()
        {
            Caption model = new()
            {
                Context = 1,
                FieldName = "FIELD",
                Language = "LANG",
                SourceTable = "TABLE",
                Text = "TXT"
            };

            Result response = await _dimeSchedulerClientFixture.Client.Captions.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}