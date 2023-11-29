using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public interface IAppointmentEndpoint :
        ICrudEndpoint<Appointment>,
        ICrudEndpoint<AppointmentCategory>,
        ICrudEndpoint<AppointmentContent>,
        ICrudEndpoint<AppointmentLocked>,
        ICrudEndpoint<AppointmentTimeMarker>,
        ICrudEndpoint<AppointmentUri>,
        ICrudEndpoint<AppointmentContainer>,
        ICrudEndpoint<Assignment>
    {
    }
}