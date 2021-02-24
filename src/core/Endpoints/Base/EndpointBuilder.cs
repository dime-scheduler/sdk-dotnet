using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public abstract class EndpointBuilder<T>
    {
        private readonly IAuthenticator _authenticator;
        private readonly string _uri;

        protected EndpointBuilder(string uri, IAuthenticator authenticator)
        {
            _uri = uri;
            _authenticator = authenticator;
        }

        protected abstract T Create(AuthenticationOptions opts);

        internal async Task<T> Create()
        {
            string authenticationToken = await _authenticator.AuthenticateAsync();
            return Create(new AuthenticationOptions(_uri, authenticationToken));
        }
    }
}