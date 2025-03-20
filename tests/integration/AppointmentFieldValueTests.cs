using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class AppointmentFieldValueTests: IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public AppointmentFieldValueTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }
        private static AppointmentFieldValue CreateModel()
            => new()
            {
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                SourceApp = "APP",
                SourceType = "TYPE",
                FieldCode = "ISCOMPLETE",
                FieldValue = "true"
            };

        [Fact]
        public async System.Threading.Tasks.Task AppointmentFieldValue_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentFieldValue model = CreateModel();

            Result response = await _dimeSchedulerClientFixture.Client.Appointments.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}