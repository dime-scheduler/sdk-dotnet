using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IEndpointBuilder<T> where T : IEndpoint
    {
        Task<T> Request();
    }
}