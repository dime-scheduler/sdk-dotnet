using System.Collections.Generic;
using System.Linq;

namespace Dime.Scheduler
{
    public class AppointmentResult : Result
    {
        public AppointmentResult(bool isSuccess, string error, IEnumerable<AppointmentMap> appointments)
          : base(isSuccess, error)
        {
            Appointment = appointments.Count() > 0 ? appointments.ElementAt(0).Id : 0;
        }

        public long Appointment { get; }

        internal static AppointmentResult Ok(IEnumerable<AppointmentMap> appointments)
            => new(true, string.Empty, appointments);
    }
}