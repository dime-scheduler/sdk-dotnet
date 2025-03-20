using System;
using System.Collections.Generic;
using Dime.Scheduler.Entities;
using Dime.Scheduler.Entities.Exchange;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class ExchangeAppointmentTests
    {
        [Fact]
        public void ExchangeAppointment_ToImportRequest_Append_AllShouldMapParameters()
        {
            ExchangeAppointment model = new()
            {
                Importance = Importance.Low,
                Subject = "SUB",
                AppointmentId = 1,
                AppointmentGuid = Guid.NewGuid(),
                Body = "BODY",
                Start = new DateTime(2020, 1, 1, 15, 30, 0),
                End = new DateTime(2020, 1, 1, 16, 30, 0),
                Categories = new List<string> { "1", "2" },
                ExchangeId = "1",
                ICalUId = "1",
                ResourceEmail = "email",
                ShowAs = ShowAs.Office,
                Sensitivity = Sensitivity.Confidential
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void ExchangeAppointment_ToImportRequest_Delete_AllShouldMapParameters()
        {
            ExchangeAppointment model = new()
            {
                Importance = Importance.Low,
                Subject = "SUB",
                AppointmentId = 1,
                AppointmentGuid = Guid.NewGuid(),
                Body = "BODY",
                Start = new DateTime(2020, 1, 1, 15, 30, 0),
                End = new DateTime(2020, 1, 1, 16, 30, 0),
                Categories = new List<string> { "1", "2" },
                ExchangeId = "1",
                ICalUId = "1",
                ResourceEmail = "email",
                ShowAs = ShowAs.Free,
                Sensitivity = Sensitivity.Normal
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void ExchangeAppointment_ToImportRequest_InvalidTransactionType_ShouldThrowArgumentOutOfRangeException()
            => ToImportRequestTestUtils.TestToInvalidImportRequest<ExchangeAppointment>();
    }
}