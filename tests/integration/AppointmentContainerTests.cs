using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentContainerTests
    {
        [Fact]
        public async System.Threading.Tasks.Task AppointmentContainer()
        {
            AppointmentContainer model = new()
            {
                Container = "Container 1",
                Appointment = "Appointment 1"
            };
        }
    }
}