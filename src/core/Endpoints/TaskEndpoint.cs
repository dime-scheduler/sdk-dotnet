using Dime.Scheduler.Sdk.Models;
using RestSharp;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class TaskEndpoint : Endpoint, ITaskEndpoint
    {
        public TaskEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        void ICrudEndpoint<Task>.Create(Task requestParameters)
            => ExecuteAsync(Routes.Task.Entity, Method.Post, requestParameters);

        public t.Task CreateAsync(Models.Task requestParameters)
            => ExecuteAsync(Routes.Task.Entity, Method.Post, requestParameters);

        public t.Task UpdateAsync(Models.Task requestParameters)
           => ExecuteAsync(Routes.Task.Entity, Method.Post, requestParameters);

        void ICrudEndpoint<Task>.Update(Task requestParameters)
            => ExecuteAsync(Routes.Task.Entity, Method.Post, requestParameters);

        void ICrudEndpoint<Task>.Delete(Task requestParameters)
            => ExecuteAsync(Routes.Task.Entity, Method.Delete, requestParameters);
               
        public t.Task DeleteAsync(Models.Task requestParameters)
            => ExecuteAsync(Routes.Task.Entity, Method.Delete, requestParameters);

        void ICrudEndpoint<TaskLocked>.Create(TaskLocked requestParameters)
            => ExecuteAsync(Routes.Task.Locked, Method.Post, requestParameters);

        void ICrudEndpoint<TaskLocked>.Update(TaskLocked requestParameters)
            => ExecuteAsync(Routes.Task.Locked, Method.Post, requestParameters);

        void ICrudEndpoint<TaskLocked>.Delete(TaskLocked requestParameters)
            => ExecuteAsync(Routes.Task.Locked, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<TaskLocked>.CreateAsync(TaskLocked requestParameters)
            => ExecuteAsync(Routes.Task.Locked, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskLocked>.UpdateAsync(TaskLocked requestParameters)
            => ExecuteAsync(Routes.Task.Locked, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskLocked>.DeleteAsync(TaskLocked requestParameters)
            => ExecuteAsync(Routes.Task.Locked, Method.Delete, requestParameters);

        void ICrudEndpoint<TaskUri>.Create(TaskUri requestParameters)
            => ExecuteAsync(Routes.Task.Uri, Method.Post, requestParameters);

        void ICrudEndpoint<TaskUri>.Update(TaskUri requestParameters)
            => ExecuteAsync(Routes.Task.Uri, Method.Post, requestParameters);

        void ICrudEndpoint<TaskUri>.Delete(TaskUri requestParameters)
             => ExecuteAsync(Routes.Task.Uri, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<TaskUri>.CreateAsync(TaskUri requestParameters)
            => ExecuteAsync(Routes.Task.Uri, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskUri>.UpdateAsync(TaskUri requestParameters)
            => ExecuteAsync(Routes.Task.Uri, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskUri>.DeleteAsync(TaskUri requestParameters)
            => ExecuteAsync(Routes.Task.Uri, Method.Delete, requestParameters);

        void ICrudEndpoint<TaskContainer>.Create(TaskContainer requestParameters)
            => ExecuteAsync(Routes.Task.Container, Method.Post, requestParameters);

        void ICrudEndpoint<TaskContainer>.Update(TaskContainer requestParameters)
            => ExecuteAsync(Routes.Task.Container, Method.Post, requestParameters);

        void ICrudEndpoint<TaskContainer>.Delete(TaskContainer requestParameters)
            => ExecuteAsync(Routes.Task.Container, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<TaskContainer>.CreateAsync(TaskContainer requestParameters)
            => ExecuteAsync(Routes.Task.Container, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskContainer>.UpdateAsync(TaskContainer requestParameters)
            => ExecuteAsync(Routes.Task.Container, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskContainer>.DeleteAsync(TaskContainer requestParameters)
            => ExecuteAsync(Routes.Task.Container, Method.Delete, requestParameters);

        void ICrudEndpoint<TaskFilterValue>.Create(TaskFilterValue requestParameters)
            => ExecuteAsync(Routes.Task.FilterValue, Method.Post, requestParameters);

        void ICrudEndpoint<TaskFilterValue>.Update(TaskFilterValue requestParameters)
             => ExecuteAsync(Routes.Task.FilterValue, Method.Post, requestParameters);

        void ICrudEndpoint<TaskFilterValue>.Delete(TaskFilterValue requestParameters)
            => ExecuteAsync(Routes.Task.FilterValue, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<TaskFilterValue>.CreateAsync(TaskFilterValue requestParameters)
            => ExecuteAsync(Routes.Task.FilterValue, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskFilterValue>.UpdateAsync(TaskFilterValue requestParameters)
            => ExecuteAsync(Routes.Task.FilterValue, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskFilterValue>.DeleteAsync(TaskFilterValue requestParameters)
            => ExecuteAsync(Routes.Task.FilterValue, Method.Delete, requestParameters);
    }
}