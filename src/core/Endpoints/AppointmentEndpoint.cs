using t = System.Threading.Tasks;
using Dime.Scheduler.Sdk.Import;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class AppointmentEndpoint : Endpoint<Appointment>, IAppointmentEndpoint
    {
        public AppointmentEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        internal AppointmentEndpoint(IDimeSchedulerRestClient<Appointment> restClient)
            : base(restClient)
        {
        }

        public t.Task Create(Appointment requestParameters)
            => Execute(Routes.Appointment.Entity, Method.Post, requestParameters);

        public t.Task Update(Import.Appointment requestParameters)
            => Execute(Routes.Appointment.Entity, Method.Put, requestParameters);

        public t.Task Delete(Import.Appointment requestParameters)
            => Execute(Routes.Appointment.Entity, Method.Delete, requestParameters);
    }
}