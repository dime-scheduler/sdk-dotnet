using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IEndpointServiceBuilder<T> where T : IEndpointService
    {
        Task<T> Request();
    }
}