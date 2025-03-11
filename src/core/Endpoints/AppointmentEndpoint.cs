using Dime.Scheduler.Entities;
using RestSharp;
using t = System.Threading.Tasks;

namespace Dime.Scheduler
{
    internal class AppointmentEndpoint : Endpoint, IAppointmentEndpoint
    {
        internal AppointmentEndpoint(EndpointOptions opts)
            : base(opts)
        {
        }

        t.Task<Result> ICrudEndpoint<Appointment>.CreateAsync(Appointment requestParameters)
            => ExecuteAsync(Routes.Appointment.Entity, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<Appointment>.UpdateAsync(Appointment requestParameters)
            => ExecuteAsync(Routes.Appointment.Entity, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<Appointment>.DeleteAsync(Appointment requestParameters)
            => ExecuteAsync(Routes.Appointment.Entity, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<Assignment>.CreateAsync(Assignment requestParameters)
            => ExecuteAsync(Routes.Appointment.Assignment, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<Assignment>.UpdateAsync(Assignment requestParameters)
            => ExecuteAsync(Routes.Appointment.Assignment, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<Assignment>.DeleteAsync(Assignment requestParameters)
            => ExecuteAsync(Routes.Appointment.Assignment, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentCategory>.CreateAsync(AppointmentCategory requestParameters)
            => ExecuteAsync(Routes.Appointment.Category, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentCategory>.UpdateAsync(AppointmentCategory requestParameters)
            => ExecuteAsync(Routes.Appointment.Category, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentCategory>.DeleteAsync(AppointmentCategory requestParameters)
            => ExecuteAsync(Routes.Appointment.Category, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContent>.CreateAsync(AppointmentContent requestParameters)
            => ExecuteAsync(Routes.Appointment.Content, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContent>.UpdateAsync(AppointmentContent requestParameters)
            => ExecuteAsync(Routes.Appointment.Content, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContent>.DeleteAsync(AppointmentContent requestParameters)
            => ExecuteAsync(Routes.Appointment.Content, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentLocked>.CreateAsync(AppointmentLocked requestParameters)
            => ExecuteAsync(Routes.Appointment.Locked, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentLocked>.UpdateAsync(AppointmentLocked requestParameters)
            => ExecuteAsync(Routes.Appointment.Locked, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentLocked>.DeleteAsync(AppointmentLocked requestParameters)
            => ExecuteAsync(Routes.Appointment.Locked, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentTimeMarker>.CreateAsync(AppointmentTimeMarker requestParameters)
            => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentTimeMarker>.UpdateAsync(AppointmentTimeMarker requestParameters)
            => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentTimeMarker>.DeleteAsync(AppointmentTimeMarker requestParameters)
            => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentUri>.CreateAsync(AppointmentUri requestParameters)
            => ExecuteAsync(Routes.Appointment.Uri, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentUri>.UpdateAsync(AppointmentUri requestParameters)
            => ExecuteAsync(Routes.Appointment.Uri, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentUri>.DeleteAsync(AppointmentUri requestParameters)
            => ExecuteAsync(Routes.Appointment.Uri, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContainer>.CreateAsync(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContainer>.UpdateAsync(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContainer>.DeleteAsync(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Delete, requestParameters);
    }
}