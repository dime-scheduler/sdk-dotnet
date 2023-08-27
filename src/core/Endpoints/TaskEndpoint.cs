using t = System.Threading.Tasks;
using RestSharp;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.Sdk
{
    public class TaskEndpoint : Endpoint, ITaskEndpoint
    {
        public TaskEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public t.Task Create(Import.Task requestParameters)
            => Execute(Routes.Task.Entity, Method.Post, requestParameters);

        public t.Task Update(Import.Task requestParameters)
            => Execute(Routes.Task.Entity, Method.Post, requestParameters);

        public t.Task Delete(Import.Task requestParameters)
            => Execute(Routes.Task.Entity, Method.Delete, requestParameters);
            
        t.Task ICrudEndpoint<TaskLocked>.Create(TaskLocked requestParameters)
            => Execute(Routes.Task.Locked, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskLocked>.Update(TaskLocked requestParameters)
            => Execute(Routes.Task.Locked, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskLocked>.Delete(TaskLocked requestParameters)
            => Execute(Routes.Task.Locked, Method.Delete, requestParameters);
       
        t.Task ICrudEndpoint<TaskUri>.Create(TaskUri requestParameters)
            => Execute(Routes.Task.Uri, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskUri>.Update(TaskUri requestParameters)
            => Execute(Routes.Task.Uri, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskUri>.Delete(TaskUri requestParameters)
            => Execute(Routes.Task.Uri, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<TaskContainer>.Create(TaskContainer requestParameters)
            => Execute(Routes.Task.Container, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskContainer>.Update(TaskContainer requestParameters)
            => Execute(Routes.Task.Container, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskContainer>.Delete(TaskContainer requestParameters)
            => Execute(Routes.Task.Container, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<TaskFilterValue>.Create(TaskFilterValue requestParameters)
               => Execute(Routes.Task.FilterValue, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskFilterValue>.Update(TaskFilterValue requestParameters)
            => Execute(Routes.Task.FilterValue, Method.Post, requestParameters);

        t.Task ICrudEndpoint<TaskFilterValue>.Delete(TaskFilterValue requestParameters)
            => Execute(Routes.Task.FilterValue, Method.Delete, requestParameters);    
    }
}