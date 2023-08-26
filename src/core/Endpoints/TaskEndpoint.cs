using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class TaskEndpoint : Endpoint<Import.Task>, ITaskEndpoint
    {
        public TaskEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        internal TaskEndpoint(IDimeSchedulerRestClient<Import.Task> restClient)
            : base(restClient)
        {
        }

        public Task Create(Import.Task requestParameters)
            => Execute(Routes.Task.Entity, Method.Post, requestParameters);

        public Task Update(Import.Task requestParameters)
            => Execute(Routes.Task.Entity, Method.Put, requestParameters);

        public Task Delete(Import.Task requestParameters)
            => Execute(Routes.Task.Entity, Method.Delete, requestParameters);
    }
}