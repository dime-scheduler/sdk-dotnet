using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class AppointmentTests
    {
        [Fact]
        public void Appointment_ToImportRequest_Append_AllShouldMapParameters()
        {
            Appointment model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                Start = new DateTime(2020, 1, 1),
                End = new DateTime(2020, 1, 2),
                ResourceNo = "NO",
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                BackOfficeId = "1",
                BackOfficeParentId = "2",
                Body = "Body",
                Subject = "Subject",
                Category = "CAT",
                Importance = 1,
                IsAllDay = false,
                JobNo = "Job",
                Locked = true,
                PlanningQuantity = 525,
                ReplaceResource = true,
                RoundToUnitOfMeasure = true,
                TaskNo = "TASK",
                TimeMarker = "TM",
                UnitOfMeasure = "UOM",
                UnitOfMeasureConversion = 14,
                UseFixedPlanningQuantity = true
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Appointment_ToImportRequest_Delete_AllShouldMapParameters()
        {
            Appointment model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                Start = new DateTime(2020, 1, 1),
                End = new DateTime(2020, 1, 2),
                ResourceNo = "NO",
                AppointmentGuid = Guid.NewGuid(),
                AppointmentId = 1,
                SentFromBackOffice = true,
                BackOfficeId = "1",
                BackOfficeParentId = "2",
                Body = "Body",
                Subject = "Subject",
                Category = "CAT",
                Importance = 1,
                IsAllDay = false,
                JobNo = "Job",
                Locked = true,
                PlanningQuantity = 525,
                ReplaceResource = true,
                RoundToUnitOfMeasure = true,
                TaskNo = "TASK",
                TimeMarker = "TM",
                UnitOfMeasure = "UOM",
                UnitOfMeasureConversion = 14,
                UseFixedPlanningQuantity = true
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void Appointment_ToImportRequest_InvalidTransactionType_ShouldThrowArgumentOutOfRangeException()
            => ToImportRequestTestUtils.TestToInvalidImportRequest<Appointment>();

        [Fact]
        public void Appointment_ToImportRequest_Append_ShouldMapRequiredParameters()
        {
            Appointment model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                Start = new DateTime(2020, 1, 1),
                End = new DateTime(2020, 1, 2),
                JobNo = "JOB",
                TaskNo = "TASK",
                ResourceNo = "NO"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
            Assert.True(importRequest.ParameterNames.Length == 7);
            Assert.True(importRequest.ParameterValues.Length == 7);
        }
    }
}