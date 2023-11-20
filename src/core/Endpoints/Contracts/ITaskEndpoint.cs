using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.Sdk
{
    public interface ITaskEndpoint :
        ICrudEndpoint<Task>,
        ICrudEndpoint<TaskFilterValue>,
        ICrudEndpoint<TaskLocked>,
        ICrudEndpoint<TaskUri>,
        ICrudEndpoint<TaskContainer>
    {
    }
}