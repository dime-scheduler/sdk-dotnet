using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class CategoriesEndpoint : Endpoint<IndicatorRequest>, ICrudEndpoint<IndicatorRequest>
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
            => Execute(Routes.Categories.Create, Method.Post, requestParameters);

        public Task Update(IndicatorRequest requestParameters)
            => Execute(Routes.Categories.Update, Method.Put, requestParameters);

        public Task Delete(IndicatorRequest requestParameters)
            => Execute(Routes.Categories.Delete, Method.Delete, requestParameters);
    }
}