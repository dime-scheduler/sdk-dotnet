using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.Sdk
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