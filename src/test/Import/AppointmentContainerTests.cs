using System;
using Dime.Scheduler.Sdk.Models;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class AppointmentContainerTests
    {
        [Fact]
        public void AppointmentContainer_ToImportRequest_Append_AllShouldMapParameters()
        {
            AppointmentContainer model = new()
            {
                Container = "Container 1",
                Appointment = "Appointment 1"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void AppointmentContainer_Append_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            AppointmentContainer model = new() { Container = "Container 1", Appointment = "Appointment 1" };
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[0] == "Container");
            Assert.True(importRequest.ParameterValues[0] == "Container 1");
        }

        [Fact]
        public void AppointmentContainer_Append_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            AppointmentContainer model = new();
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Append));
        }

        [Fact]
        public void AppointmentContainer_ToImportRequest_Delete_AllShouldMapParameters()
        {
            AppointmentContainer model = new()
            {
                Container = "Container 1",
                Appointment = "Appointment 1"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void AppointmentContainer_Delete_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            AppointmentContainer model = new();
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Delete));
        }
    }
}