using System;
using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler
{
    [ExcludeFromCodeCoverage]
    public class AppointmentMap
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
    }
}