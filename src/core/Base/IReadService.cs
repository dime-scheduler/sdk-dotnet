using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IReadService<in T, Y> : IEndpointService where T : class
    {
        Task<IEnumerable<Y>> GetAsync(T request);
    }
}