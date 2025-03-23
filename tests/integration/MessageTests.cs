using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class MessageTest : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public MessageTest(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task Message()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            Message model = new()
            {
                Severity = Severity.Warning,
                Text = "This is a test message",                
            };

            Result response = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Messages.PostAsync(model));
            Assert.True(response.IsSuccess, response.Error?.ToString());
        }
    }
}