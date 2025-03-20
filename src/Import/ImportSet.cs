using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Dime.Scheduler.Entities
{
    [ExcludeFromCodeCoverage]
    public class ImportSet
    {
        public bool Success { get; set; }
        
        public string Message { get; set; }
        
        public int Status { get; set; }
        
        public string? Phrase { get; set; }

        [JsonIgnore]
        public List<AppointmentMap> Appointments { get; set; }
    }
}