using System.Collections.Generic;
using System.Linq;

namespace Dime.Scheduler
{
    public class AppointmentResult : Result
    {
        public AppointmentResult(bool isSuccess, IEnumerable<AppointmentMap> appointments) : base(isSuccess)
        {
            Appointment = appointments.Count() > 0 ? appointments.ElementAt(0).Id : 0;
        }

        public long Appointment { get; }

        internal static AppointmentResult Ok(IEnumerable<AppointmentMap> appointments)
            => new(true, appointments);
    }
}