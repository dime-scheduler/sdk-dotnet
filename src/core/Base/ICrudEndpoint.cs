using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface ICrudEndpoint<in T> : IEndpoint where T : class
    {
        Task Create(T requestParameters);

        Task Update(T requestParameters);

        Task Delete(T requestParameters);
    }
}