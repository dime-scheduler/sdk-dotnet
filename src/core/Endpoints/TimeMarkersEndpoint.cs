using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class TimeMarkersEndpoint : Endpoint<IndicatorRequest>, ICrudEndpoint<IndicatorRequest>
    {
        public TimeMarkersEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        internal TimeMarkersEndpoint(IDimeSchedulerRestClient<IndicatorRequest> restClient) 
            : base(restClient)
        {
        }

        public Task Create(IndicatorRequest requestParameters)
            => Execute(Routes.TimeMarkers.Create, Method.POST, requestParameters);

        public Task Update(IndicatorRequest requestParameters)
            => Execute(Routes.TimeMarkers.Update, Method.PUT, requestParameters);

        public Task Delete(IndicatorRequest requestParameters)
            => Execute(Routes.TimeMarkers.Delete, Method.DELETE, requestParameters);
    }
}