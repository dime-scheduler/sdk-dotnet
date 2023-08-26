using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class CategoriesEndpoint : Endpoint<IndicatorRequest>, ICategoryEndpoint
    {
        public CategoriesEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        internal CategoriesEndpoint(IDimeSchedulerRestClient<IndicatorRequest> restClient)
            : base(restClient)
        {
        }

        public Task Create(IndicatorRequest requestParameters)
            => Execute(Routes.Category, Method.Post, requestParameters);

        public Task Update(IndicatorRequest requestParameters)
            => Execute(Routes.Category, Method.Put, requestParameters);

        public Task Delete(IndicatorRequest requestParameters)
            => Execute(Routes.Category, Method.Delete, requestParameters);
    }
}