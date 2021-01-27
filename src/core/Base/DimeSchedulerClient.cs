using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{

    public abstract class EndpointServiceBuilder<T>
    {
        private readonly IAuthenticator _authn;
        private readonly string _uri;

        public EndpointServiceBuilder(string uri, IAuthenticator authn)
        {
            _uri = uri;
            _authn = authn;
        }

        protected abstract T Create(AuthenticationOptions opts);

        internal async Task<T> Create()
        {
            string authenticationToken = await _authn.AuthenticateAsync();
            return Create(new AuthenticationOptions { AuthenticationToken = authenticationToken, Uri = _uri });
        }
    }

    public class DimeSchedulerClient
    {
        public IImportEndpointServiceBuilder Import { get; }
        public IResourceEndpointServiceBuilder Resources { get; }
        public ICategoryEndpointServiceBuilder Categories { get; }

        public DimeSchedulerClient(string uri, IAuthenticator authenticator)
        {
            Import = new ImportEndpointServiceBuilder(uri, authenticator);
            Resources = new ResourcesEndpointServiceBuilder(uri, authenticator);
            Categories = new CategoriesEndpointServiceBuilder(uri, authenticator);
        }
    }
}