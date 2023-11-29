using Dime.Scheduler.Entities;

namespace Dime.Scheduler
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