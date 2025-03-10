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

        public Task<Result> CreateAsync(User requestParameters)
            => ExecuteAsync(Routes.Users.Create, Method.Post, requestParameters);

        public Task<Result> UpdateAsync(User requestParameters)
            => ExecuteAsync(Routes.Users.Update, Method.Post, requestParameters);

        public Task<Result> DeleteAsync(User requestParameters)
            => ExecuteAsync(Routes.Users.Delete, Method.Post, requestParameters);
    }
}