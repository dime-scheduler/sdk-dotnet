using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class TimeMarkersEndpointBuilder : EndpointBuilder<TimeMarkersEndpoint>, ITimeMarkerEndpointBuilder
    {
        public TimeMarkersEndpointBuilder(string uri, IAuthenticator authn)
            : base(uri, authn)
        {
        }

        public async Task<ICrudEndpoint<IndicatorRequest>> Request()
         => await Create();

        protected override TimeMarkersEndpoint Create(AuthenticationOptions opts)
        => new(opts);
    }
}