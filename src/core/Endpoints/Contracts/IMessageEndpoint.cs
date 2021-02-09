using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IMessageEndpoint : IEndpoint
    {
        Task PostAsync(MessageRequest request);
    }
}