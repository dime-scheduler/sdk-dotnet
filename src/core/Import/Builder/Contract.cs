using System;

namespace Dime.Scheduler.Sdk.Import.Builder
{
    public class Contract
    {
        public string No { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}