using Dime.Scheduler.Entities;
using RestSharp;
using t = System.Threading.Tasks;

namespace Dime.Scheduler
{
    public class ResourcesEndpoint : Endpoint, IResourceEndpoint
    {
        public ResourcesEndpoint(EndpointOptions opts)
            : base(opts)
        {
        }

        t.Task<Result> ICrudEndpoint<Resource>.CreateAsync(Resource requestParameters)
            => ExecuteAsync(Routes.Resource.Entity, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<Resource>.UpdateAsync(Resource requestParameters)
          => ExecuteAsync(Routes.Resource.Entity, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<Resource>.DeleteAsync(Resource requestParameters)
            => ExecuteAsync(Routes.Resource.Entity, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceFilterValue>.CreateAsync(ResourceFilterValue requestParameters)
            => ExecuteAsync(Routes.Resource.FilterValue, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceFilterValue>.UpdateAsync(ResourceFilterValue requestParameters)
           => ExecuteAsync(Routes.Resource.FilterValue, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceFilterValue>.DeleteAsync(ResourceFilterValue requestParameters)
            => ExecuteAsync(Routes.Resource.FilterValue, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceCalendar>.CreateAsync(ResourceCalendar requestParameters)
            => ExecuteAsync(Routes.Resource.Calendar, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceCalendar>.UpdateAsync(ResourceCalendar requestParameters)
         => ExecuteAsync(Routes.Resource.Calendar, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceCalendar>.DeleteAsync(ResourceCalendar requestParameters)
           => ExecuteAsync(Routes.Resource.Calendar, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceCapacity>.CreateAsync(ResourceCapacity requestParameters)
            => ExecuteAsync(Routes.Resource.Capacity, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceCapacity>.UpdateAsync(ResourceCapacity requestParameters)
            => ExecuteAsync(Routes.Resource.Capacity, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceCapacity>.DeleteAsync(ResourceCapacity requestParameters)
           => ExecuteAsync(Routes.Resource.Capacity, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceGpsTracking>.CreateAsync(ResourceGpsTracking requestParameters)
            => ExecuteAsync(Routes.Resource.GpsTracking, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceGpsTracking>.UpdateAsync(ResourceGpsTracking requestParameters)
           => ExecuteAsync(Routes.Resource.GpsTracking, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceGpsTracking>.DeleteAsync(ResourceGpsTracking requestParameters)
            => ExecuteAsync(Routes.Resource.GpsTracking, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceCertificate>.CreateAsync(ResourceCertificate requestParameters)
            => ExecuteAsync(Routes.Resource.Certificate, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceCertificate>.UpdateAsync(ResourceCertificate requestParameters)
            => ExecuteAsync(Routes.Resource.Certificate, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<ResourceCertificate>.DeleteAsync(ResourceCertificate requestParameters)
            => ExecuteAsync(Routes.Resource.Certificate, Method.Delete, requestParameters);
    }
}