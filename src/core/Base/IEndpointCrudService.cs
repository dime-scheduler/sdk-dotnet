using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public interface IEndpointCrudService<in T> : IEndpointService where T : class
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="requestParameters"></param>
        /// <returns></returns>
        Task Create(T requestParameters);

        /// <summary>
        ///
        /// </summary>
        /// <param name="requestParameters"></param>
        /// <returns></returns>
        Task Update(T requestParameters);

        /// <summary>
        ///
        /// </summary>
        /// <param name="requestParameters"></param>
        /// <returns></returns>
        Task Delete(T requestParameters);
    }
}