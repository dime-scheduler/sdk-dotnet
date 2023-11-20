using System;
using Dime.Scheduler.Sdk.Models;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class ResourceCalendarTests
    {
        [Fact]
        public void ResourceCalendar_ToImportRequest_Append_AllShouldMapParameters()
        {
            ResourceCalendar model = new()
            {
                ResourceNo = "RESOURCE1",
                CalendarCode = "CODE",
                EndDate = new DateTime(2020, 1, 1),
                StartDate = new DateTime(2019, 1, 3),
                Code = "CODE"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void ResourceCalendar_ToImportRequest_Delete_AllShouldMapParameters()
        {
            ResourceCalendar model = new()
            {
                ResourceNo = "RESOURCE1",
                CalendarCode = "CODE",
                EndDate = new DateTime(2020, 1, 1),
                StartDate = new DateTime(2019, 1, 3),
                Code = "CODE"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void ResourceCalendar_ToImportRequest_InvalidTransactionType_ShouldThrowArgumentOutOfRangeException()
            => ToImportRequestTestUtils.TestToInvalidImportRequest<ResourceCalendar>();
    }
}