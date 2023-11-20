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

        void ICrudEndpoint<UserRequest>.Create(UserRequest requestParameters)
            => Execute(Routes.Users.Create, Method.Post, requestParameters);

        public Task CreateAsync(UserRequest requestParameters)
            => ExecuteAsync(Routes.Users.Create, Method.Post, requestParameters);

        void ICrudEndpoint<UserRequest>.Update(UserRequest requestParameters)
            => Execute(Routes.Users.Update, Method.Post, requestParameters);

        public Task UpdateAsync(UserRequest requestParameters)
            => ExecuteAsync(Routes.Users.Update, Method.Post, requestParameters);

        public Task DeleteAsync(UserRequest requestParameters)
            => ExecuteAsync(Routes.Users.Delete, Method.Post, requestParameters);

        void ICrudEndpoint<UserRequest>.Delete(UserRequest requestParameters)
              => Execute(Routes.Users.Delete, Method.Post, requestParameters);
    }
}