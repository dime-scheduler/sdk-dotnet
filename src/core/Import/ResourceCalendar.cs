using System;
using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceCalendar : IImportRequestable
    {
        public string Code { get; set; }

        public string ResourceNo { get; set; }

        public string CalendarCode { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => new ImportRequest(
                "mboc_upsertFilterGroup",
                new List<string> { "ResourceCalendarCode", "ResourceNo", "CalendarCode", "StartDate", "EndDate" }.ToArray(),
                new List<string> { Code, ResourceNo, CalendarCode, StartDate.ToString("s"), EndDate.ToString("s") }.ToArray());
    }
}