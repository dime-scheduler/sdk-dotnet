using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IEndpointCrudService<in T> : IEndpointService where T : class
    {
        Task Create(T requestParameters);

        Task Update(T requestParameters);

        Task Delete(T requestParameters);
    }
}