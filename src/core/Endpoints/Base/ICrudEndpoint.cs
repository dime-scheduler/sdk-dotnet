using System.Threading.Tasks;

namespace Dime.Scheduler
{
    public interface ICrudEndpoint<in T> : IEndpoint where T : class
    {
        void Create(T requestParameters);

        Task CreateAsync(T requestParameters);

        void Update(T requestParameters);

        Task UpdateAsync(T requestParameters);

        void Delete(T requestParameters);

        Task DeleteAsync(T requestParameters);
    }
}