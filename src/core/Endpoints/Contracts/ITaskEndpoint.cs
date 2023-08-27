namespace Dime.Scheduler.Sdk
{
    public interface ITaskEndpoint :
        ICrudEndpoint<Import.Task>,
        ICrudEndpoint<Import.TaskFilterValue>,
        ICrudEndpoint<Import.TaskLocked>,
        ICrudEndpoint<Import.TaskUri>,
        ICrudEndpoint<Import.TaskContainer>
    {
    }
}