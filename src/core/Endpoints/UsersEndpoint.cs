using System.Threading.Tasks;
using RestSharp;
using User = Dime.Scheduler.Entities.User;

namespace Dime.Scheduler
{
    public class UsersEndpoint : Endpoint<User>, ICrudEndpoint<User>, IUserEndpoint
    {
        public UsersEndpoint(EndpointOptions opts)
            : base(opts)
        {
        }

        internal UsersEndpoint(IDimeSchedulerRestClient<User> restClient)
            : base(restClient)
        {
        }

        void ICrudEndpoint<User>.Create(User requestParameters)
            => Execute(Routes.Users.Create, Method.Post, requestParameters);

        public Task CreateAsync(User requestParameters)
            => ExecuteAsync(Routes.Users.Create, Method.Post, requestParameters);

        void ICrudEndpoint<User>.Update(User requestParameters)
            => Execute(Routes.Users.Update, Method.Post, requestParameters);

        public Task UpdateAsync(User requestParameters)
            => ExecuteAsync(Routes.Users.Update, Method.Post, requestParameters);

        public Task DeleteAsync(User requestParameters)
            => ExecuteAsync(Routes.Users.Delete, Method.Post, requestParameters);

        void ICrudEndpoint<User>.Delete(User requestParameters)
              => Execute(Routes.Users.Delete, Method.Post, requestParameters);
    }
}