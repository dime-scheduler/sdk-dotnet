using System.Threading.Tasks;

namespace Dime.Scheduler
{
    public interface ICrudEndpoint<in T> : IEndpoint where T : class
    {
        Task<Result> CreateAsync(T requestParameters);

        Task<Result> UpdateAsync(T requestParameters);

        Task<Result> DeleteAsync(T requestParameters);
    }
}