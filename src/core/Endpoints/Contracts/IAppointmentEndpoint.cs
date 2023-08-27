namespace Dime.Scheduler.Sdk
{
    public interface IAppointmentEndpoint :
        ICrudEndpoint<Import.Appointment>,
        ICrudEndpoint<Import.AppointmentCategory>,
        ICrudEndpoint<Import.AppointmentContent>,
        ICrudEndpoint<Import.AppointmentLocked>,
        ICrudEndpoint<Import.AppointmentTimeMarker>,
        ICrudEndpoint<Import.AppointmentUri>,
        ICrudEndpoint<Import.AppointmentContainer>,
        ICrudEndpoint<Import.Assignment>
    {
    }
}