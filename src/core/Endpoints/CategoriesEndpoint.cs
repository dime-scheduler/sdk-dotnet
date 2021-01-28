using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class CategoriesEndpoint : Endpoint<CategoryRequest>, ICrudEndpoint<CategoryRequest>
    {
        public CategoriesEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public Task Create(CategoryRequest requestParameters)
            => Execute(Routes.Categories.Create, Method.POST, requestParameters);

        public Task Update(CategoryRequest requestParameters)
            => Execute(Routes.Categories.Update, Method.PUT, requestParameters);

        public Task Delete(CategoryRequest requestParameters)
            => Execute(Routes.Categories.Delete, Method.DELETE, requestParameters);
    }
}