using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class CategoriesEndpointBuilder : EndpointBuilder<CategoriesEndpoint>, ICategoryEndpointBuilder
    {
        public CategoriesEndpointBuilder(string uri, IAuthenticator authn)
            : base(uri, authn)
        {
        }

        public async Task<ICrudEndpoint<CategoryRequest>> Request()
         => await Create();

        protected override CategoriesEndpoint Create(AuthenticationOptions opts)
        => new CategoriesEndpoint(opts);
    }
}