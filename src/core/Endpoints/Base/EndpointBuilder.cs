using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public abstract class EndpointBuilder<T>
    {
        private readonly IAuthenticator _authn;
        private readonly string _uri;

        public EndpointBuilder(string uri, IAuthenticator authn)
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
}