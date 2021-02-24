using System;
using System.Collections.Generic;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class ExchangeAppointmentTests
    {
        [Fact]
        public void ExchangeAppointment_ToImportRequest_Append_AllShouldMapParameters()
        {
            ExchangeAppointment model = new()
            {
                Importance = "1",
                Subject = "SUB",
                AppointmentId = 1,
                AppointmentGuid = Guid.NewGuid(),
                Body = "BODY",
                Start = new DateTime(2020, 1, 1, 15, 30, 0),
                End = new DateTime(2020, 1, 1, 16, 30, 0),
                Categories = new List<string>() { "1", "2" },
                ExchangeId = "1",
                ICalUId = "1",
                ResourceEmail = "email"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}