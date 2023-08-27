using Dime.Scheduler.Sdk.Import;
using RestSharp;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class AppointmentEndpoint : Endpoint, IAppointmentEndpoint
    {
        public AppointmentEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public t.Task Create(Appointment requestParameters)
            => Execute(Routes.Appointment.Entity, Method.Post, requestParameters);

        public t.Task Update(Appointment requestParameters)
            => Execute(Routes.Appointment.Entity, Method.Post, requestParameters);

        public t.Task Delete(Appointment requestParameters)
            => Execute(Routes.Appointment.Entity, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<Assignment>.Create(Assignment requestParameters)
            => Execute(Routes.Appointment.Assignment, Method.Post, requestParameters);

        t.Task ICrudEndpoint<Assignment>.Update(Assignment requestParameters)
            => Execute(Routes.Appointment.Assignment, Method.Post, requestParameters);

        t.Task ICrudEndpoint<Assignment>.Delete(Assignment requestParameters)
            => Execute(Routes.Appointment.Assignment, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentCategory>.Create(AppointmentCategory requestParameters)
            => Execute(Routes.Appointment.Category, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentCategory>.Update(AppointmentCategory requestParameters)
            => Execute(Routes.Appointment.Category, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentCategory>.Delete(AppointmentCategory requestParameters)
            => Execute(Routes.Appointment.Category, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentContent>.Create(AppointmentContent requestParameters)
            => Execute(Routes.Appointment.Content, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentContent>.Update(AppointmentContent requestParameters)
            => Execute(Routes.Appointment.Content, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentContent>.Delete(AppointmentContent requestParameters)
            => Execute(Routes.Appointment.Content, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentLocked>.Create(AppointmentLocked requestParameters)
            => Execute(Routes.Appointment.Locked, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentLocked>.Update(AppointmentLocked requestParameters)
            => Execute(Routes.Appointment.Locked, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentLocked>.Delete(AppointmentLocked requestParameters)
            => Execute(Routes.Appointment.Locked, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentTimeMarker>.Create(AppointmentTimeMarker requestParameters)
            => Execute(Routes.Appointment.TimeMarker, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentTimeMarker>.Update(AppointmentTimeMarker requestParameters)
            => Execute(Routes.Appointment.TimeMarker, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentTimeMarker>.Delete(AppointmentTimeMarker requestParameters)
            => Execute(Routes.Appointment.TimeMarker, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentUri>.Create(AppointmentUri requestParameters)
            => Execute(Routes.Appointment.Uri, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentUri>.Update(AppointmentUri requestParameters)
            => Execute(Routes.Appointment.Uri, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentUri>.Delete(AppointmentUri requestParameters)
            => Execute(Routes.Appointment.Uri, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentContainer>.Create(AppointmentContainer requestParameters)
            => Execute(Routes.Appointment.Container, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentContainer>.Update(AppointmentContainer requestParameters)
            => Execute(Routes.Appointment.Container, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentContainer>.Delete(AppointmentContainer requestParameters)
            => Execute(Routes.Appointment.Container, Method.Delete, requestParameters);
    }
}