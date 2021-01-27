using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class CategoriesEndpointServiceBuilder : EndpointServiceBuilder<CategoriesEndpointService>, ICategoryEndpointServiceBuilder
    {
        public CategoriesEndpointServiceBuilder(string uri, IAuthenticator authn)
            : base(uri, authn)
        {
        }

        public async Task<IEndpointCrudService<CategoryRequest>> Request()
         => await Create();

        protected override CategoriesEndpointService Create(AuthenticationOptions opts)
        => new CategoriesEndpointService(opts);
    }
}