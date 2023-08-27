using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class UsersEndpoint : Endpoint<UserRequest>, ICrudEndpoint<UserRequest>, IUserEndpoint
    {
        public UsersEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        internal UsersEndpoint(IDimeSchedulerRestClient<UserRequest> restClient)
            : base(restClient)
        {
        }

        public Task Create(UserRequest requestParameters)
            => Execute(Routes.Users.Create, Method.Post, requestParameters);

        public Task Update(UserRequest requestParameters)
            => Execute(Routes.Users.Update, Method.Post, requestParameters);

        public Task Delete(UserRequest requestParameters)
            => Execute(Routes.Users.Delete, Method.Post, requestParameters);
    }
}