using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class PinsEndpoint : Endpoint<IndicatorRequest>, IPinEndpoint
    {
        public PinsEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        internal PinsEndpoint(IDimeSchedulerRestClient<IndicatorRequest> restClient)
            : base(restClient)
        {
        }

        public Task Create(IndicatorRequest requestParameters)
            => Execute(Routes.Pin, Method.Post, requestParameters);

        public Task Update(IndicatorRequest requestParameters)
            => Execute(Routes.Pin, Method.Post, requestParameters);

        public Task Delete(IndicatorRequest requestParameters)
            => Execute(Routes.Pin, Method.Post, requestParameters);
    }
}