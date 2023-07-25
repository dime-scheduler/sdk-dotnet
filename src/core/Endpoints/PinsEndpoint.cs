using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class PinsEndpoint : Endpoint<IndicatorRequest>, ICrudEndpoint<IndicatorRequest>
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
            => Execute(Routes.Pins.Create, Method.Post, requestParameters);

        public Task Update(IndicatorRequest requestParameters)
            => Execute(Routes.Pins.Update, Method.Put, requestParameters);

        public Task Delete(IndicatorRequest requestParameters)
            => Execute(Routes.Pins.Delete, Method.Delete, requestParameters);
    }
}