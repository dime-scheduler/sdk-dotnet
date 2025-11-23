using System;
using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler
{
    [ExcludeFromCodeCoverage]
    public class AppointmentMap
    {
        /// <summary>
        /// Gets or sets the appointment identifier.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the appointment GUID.
        /// </summary>
        public Guid Guid { get; set; }
    }
}