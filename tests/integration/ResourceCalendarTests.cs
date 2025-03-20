using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceCalendarTests
    {
        [Fact]
        public async System.Threading.Tasks.Task ResourceCalendar_ToImportRequest_Append_AllShouldMapParameters()
        {
            ResourceCalendar model = new()
            {
                ResourceNo = "RESOURCE1",
                CalendarCode = "CODE",
                EndDate = new DateTime(2020, 1, 1),
                StartDate = new DateTime(2019, 1, 3),
                Code = "CODE"
            };
        }
    }
}