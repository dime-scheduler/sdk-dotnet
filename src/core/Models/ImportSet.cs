using System.Collections.Generic;

namespace Dime.Scheduler.Sdk
{
    public class ImportSet
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public string Phrase { get; set; }

        public List<AppointmentMap> Appointments { get; set; }
    }
}