using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public class CategoriesEndpointService : EndpointService<CategoryRequest>, IEndpointCrudService<CategoryRequest>
    {
        public CategoriesEndpointService(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public Task Create(CategoryRequest requestParameters)
            => Execute("api/Categories/Create", Method.POST, requestParameters);

        public Task Update(CategoryRequest requestParameters)
            => Execute("api/Categories/Update", Method.PUT, requestParameters);

        public Task Delete(CategoryRequest requestParameters)
            => Execute("api/Categories/Delete", Method.DELETE, requestParameters);
    }
}