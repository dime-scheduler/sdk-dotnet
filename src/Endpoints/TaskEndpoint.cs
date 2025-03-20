using Dime.Scheduler.Entities;
using RestSharp;
using t = System.Threading.Tasks;

namespace Dime.Scheduler
{
    internal class TaskEndpoint : Endpoint, ITaskEndpoint
    {
        internal TaskEndpoint(EndpointOptions opts) : base(opts)
        {
        }

        public t.Task<Result> CreateAsync(Task requestParameters)
            => ExecuteAsync(Routes.Task.Entity, Method.Post, requestParameters);

        public t.Task<Result> UpdateAsync(Task requestParameters)
           => ExecuteAsync(Routes.Task.Entity, Method.Post, requestParameters);

        public t.Task<Result> DeleteAsync(Task requestParameters)
            => ExecuteAsync(Routes.Task.Entity, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskLocked>.CreateAsync(TaskLocked requestParameters)
            => ExecuteAsync(Routes.Task.Locked, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskLocked>.UpdateAsync(TaskLocked requestParameters)
            => ExecuteAsync(Routes.Task.Locked, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskLocked>.DeleteAsync(TaskLocked requestParameters)
            => ExecuteAsync(Routes.Task.Locked, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskUri>.CreateAsync(TaskUri requestParameters)
            => ExecuteAsync(Routes.Task.Uri, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskUri>.UpdateAsync(TaskUri requestParameters)
            => ExecuteAsync(Routes.Task.Uri, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskUri>.DeleteAsync(TaskUri requestParameters)
            => ExecuteAsync(Routes.Task.Uri, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskContainer>.CreateAsync(TaskContainer requestParameters)
            => ExecuteAsync(Routes.Task.Container, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskContainer>.UpdateAsync(TaskContainer requestParameters)
            => ExecuteAsync(Routes.Task.Container, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskContainer>.DeleteAsync(TaskContainer requestParameters)
            => ExecuteAsync(Routes.Task.Container, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskFilterValue>.CreateAsync(TaskFilterValue requestParameters)
            => ExecuteAsync(Routes.Task.FilterValue, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskFilterValue>.UpdateAsync(TaskFilterValue requestParameters)
            => ExecuteAsync(Routes.Task.FilterValue, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<TaskFilterValue>.DeleteAsync(TaskFilterValue requestParameters)
            => ExecuteAsync(Routes.Task.FilterValue, Method.Delete, requestParameters);
    }
}