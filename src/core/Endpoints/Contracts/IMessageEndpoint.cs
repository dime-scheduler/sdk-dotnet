using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public interface IMessageEndpoint : IEndpoint
    {
        System.Threading.Tasks.Task PostAsync(Message request);
    }
}