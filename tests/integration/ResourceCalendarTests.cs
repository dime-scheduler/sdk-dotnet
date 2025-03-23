using System;
using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceCalendarTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public ResourceCalendarTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task ResourceCalendar_ToImportRequest_Append_AllShouldMapParameters()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            ResourceCalendar model = new()
            {
                ResourceNo = EntityNos.Resource,
                CalendarCode = EntityNos.Calendar,
                EndDate = new DateTime(2020, 1, 1),
                StartDate = new DateTime(2019, 1, 3),
                Code = EntityNos.Calendar
            };

            Result response = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Resources.CreateAsync(model));
            Assert.True(response.IsSuccess, response.Error?.ToString());
        }
    }
}