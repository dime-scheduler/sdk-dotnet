using System;
using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler
{
    [ExcludeFromCodeCoverage]
    public class AppointmentMap
    {
        /// <summary>
        /// The appointment identifier.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The appointment GUID.
        /// </summary>
        public Guid Guid { get; set; }
    }
}