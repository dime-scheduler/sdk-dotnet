using Dime.Scheduler.Sdk.Models;
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

        void ICrudEndpoint<Appointment>.Create(Appointment requestParameters)
            => Execute(Routes.Appointment.Entity, Method.Post, requestParameters);

        void ICrudEndpoint<Appointment>.Update(Appointment requestParameters)
              => ExecuteAsync(Routes.Appointment.Entity, Method.Post, requestParameters);

        void ICrudEndpoint<Appointment>.Delete(Appointment requestParameters)
            => ExecuteAsync(Routes.Appointment.Entity, Method.Delete, requestParameters);

        public t.Task CreateAsync(Appointment requestParameters)
            => ExecuteAsync(Routes.Appointment.Entity, Method.Post, requestParameters);

        public t.Task UpdateAsync(Appointment requestParameters)
            => ExecuteAsync(Routes.Appointment.Entity, Method.Post, requestParameters);

        public t.Task DeleteAsync(Appointment requestParameters)
            => ExecuteAsync(Routes.Appointment.Entity, Method.Delete, requestParameters);

        void ICrudEndpoint<Assignment>.Create(Assignment requestParameters)
            => Execute(Routes.Appointment.Assignment, Method.Post, requestParameters);

        void ICrudEndpoint<Assignment>.Update(Assignment requestParameters)
            => Execute(Routes.Appointment.Assignment, Method.Post, requestParameters);

        void ICrudEndpoint<Assignment>.Delete(Assignment requestParameters)
            => Execute(Routes.Appointment.Assignment, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<Assignment>.CreateAsync(Assignment requestParameters)
            => ExecuteAsync(Routes.Appointment.Assignment, Method.Post, requestParameters);

        t.Task ICrudEndpoint<Assignment>.UpdateAsync(Assignment requestParameters)
            => ExecuteAsync(Routes.Appointment.Assignment, Method.Post, requestParameters);

        t.Task ICrudEndpoint<Assignment>.DeleteAsync(Assignment requestParameters)
            => ExecuteAsync(Routes.Appointment.Assignment, Method.Delete, requestParameters);

        void ICrudEndpoint<AppointmentCategory>.Create(AppointmentCategory requestParameters)
            => ExecuteAsync(Routes.Appointment.Category, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentCategory>.Update(AppointmentCategory requestParameters)
            => ExecuteAsync(Routes.Appointment.Category, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentCategory>.Delete(AppointmentCategory requestParameters)
            => Execute(Routes.Appointment.Category, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentCategory>.CreateAsync(AppointmentCategory requestParameters)
            => ExecuteAsync(Routes.Appointment.Category, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentCategory>.UpdateAsync(AppointmentCategory requestParameters)
            => ExecuteAsync(Routes.Appointment.Category, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentCategory>.DeleteAsync(AppointmentCategory requestParameters)
            => ExecuteAsync(Routes.Appointment.Category, Method.Delete, requestParameters);

        void ICrudEndpoint<AppointmentContent>.Create(AppointmentContent requestParameters)
             => ExecuteAsync(Routes.Appointment.Content, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentContent>.Update(AppointmentContent requestParameters)
            => ExecuteAsync(Routes.Appointment.Content, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentContent>.Delete(AppointmentContent requestParameters)
              => ExecuteAsync(Routes.Appointment.Content, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentContent>.CreateAsync(AppointmentContent requestParameters)
            => ExecuteAsync(Routes.Appointment.Content, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentContent>.UpdateAsync(AppointmentContent requestParameters)
            => ExecuteAsync(Routes.Appointment.Content, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentContent>.DeleteAsync(AppointmentContent requestParameters)
            => ExecuteAsync(Routes.Appointment.Content, Method.Delete, requestParameters);

        void ICrudEndpoint<AppointmentLocked>.Create(AppointmentLocked requestParameters)
            => ExecuteAsync(Routes.Appointment.Locked, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentLocked>.Update(AppointmentLocked requestParameters)
            => ExecuteAsync(Routes.Appointment.Locked, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentLocked>.Delete(AppointmentLocked requestParameters)
              => ExecuteAsync(Routes.Appointment.Locked, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentLocked>.CreateAsync(AppointmentLocked requestParameters)
            => ExecuteAsync(Routes.Appointment.Locked, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentLocked>.UpdateAsync(AppointmentLocked requestParameters)
            => ExecuteAsync(Routes.Appointment.Locked, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentLocked>.DeleteAsync(AppointmentLocked requestParameters)
            => ExecuteAsync(Routes.Appointment.Locked, Method.Delete, requestParameters);

        void ICrudEndpoint<AppointmentTimeMarker>.Create(AppointmentTimeMarker requestParameters)
            => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentTimeMarker>.Update(AppointmentTimeMarker requestParameters)
            => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentTimeMarker>.Delete(AppointmentTimeMarker requestParameters)
             => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentTimeMarker>.CreateAsync(AppointmentTimeMarker requestParameters)
            => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentTimeMarker>.UpdateAsync(AppointmentTimeMarker requestParameters)
            => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentTimeMarker>.DeleteAsync(AppointmentTimeMarker requestParameters)
            => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Delete, requestParameters);

        void ICrudEndpoint<AppointmentUri>.Create(AppointmentUri requestParameters)
              => ExecuteAsync(Routes.Appointment.Uri, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentUri>.Update(AppointmentUri requestParameters)
            => ExecuteAsync(Routes.Appointment.Uri, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentUri>.Delete(AppointmentUri requestParameters)
             => ExecuteAsync(Routes.Appointment.Uri, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentUri>.CreateAsync(AppointmentUri requestParameters)
            => ExecuteAsync(Routes.Appointment.Uri, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentUri>.UpdateAsync(AppointmentUri requestParameters)
            => ExecuteAsync(Routes.Appointment.Uri, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentUri>.DeleteAsync(AppointmentUri requestParameters)
            => ExecuteAsync(Routes.Appointment.Uri, Method.Delete, requestParameters);

        void ICrudEndpoint<AppointmentContainer>.Create(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentContainer>.Update(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Post, requestParameters);

        void ICrudEndpoint<AppointmentContainer>.Delete(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<AppointmentContainer>.CreateAsync(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentContainer>.UpdateAsync(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Post, requestParameters);

        t.Task ICrudEndpoint<AppointmentContainer>.DeleteAsync(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Delete, requestParameters);
    }
}