using Dime.Scheduler.Sdk.Import;
using RestSharp;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class ResourcesEndpoint : Endpoint, IResourceEndpoint
    {
        public ResourcesEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        t.Task ICrudEndpoint<Resource>.Create(Resource requestParameters)
            => Execute(Routes.Resource.Entity, Method.Post, requestParameters);

        t.Task ICrudEndpoint<Resource>.Update(Resource requestParameters)
          => Execute(Routes.Resource.Entity, Method.Post, requestParameters);

        t.Task ICrudEndpoint<Resource>.Delete(Resource requestParameters)
            => Execute(Routes.Resource.Entity, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<ResourceFilterValue>.Create(ResourceFilterValue requestParameters)
            => Execute(Routes.Resource.FilterValue, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceFilterValue>.Update(ResourceFilterValue requestParameters)
           => Execute(Routes.Resource.FilterValue, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceFilterValue>.Delete(ResourceFilterValue requestParameters)
            => Execute(Routes.Resource.FilterValue, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<ResourceCalendar>.Create(ResourceCalendar requestParameters)
            => Execute(Routes.Resource.Calendar, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCalendar>.Update(ResourceCalendar requestParameters)
         => Execute(Routes.Resource.Calendar, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCalendar>.Delete(ResourceCalendar requestParameters)
           => Execute(Routes.Resource.Calendar, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<ResourceCapacity>.Create(ResourceCapacity requestParameters)
            => Execute(Routes.Resource.Capacity, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCapacity>.Update(ResourceCapacity requestParameters)
            => Execute(Routes.Resource.Capacity, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCapacity>.Delete(ResourceCapacity requestParameters)
           => Execute(Routes.Resource.Capacity, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<ResourceGpsTracking>.Create(ResourceGpsTracking requestParameters)
            => Execute(Routes.Resource.GpsTracking, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceGpsTracking>.Update(ResourceGpsTracking requestParameters)
           => Execute(Routes.Resource.GpsTracking, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceGpsTracking>.Delete(ResourceGpsTracking requestParameters)
            => Execute(Routes.Resource.GpsTracking, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<ResourceCertificate>.Create(ResourceCertificate requestParameters)
            => Execute(Routes.Resource.Certificate, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCertificate>.Update(ResourceCertificate requestParameters)
            => Execute(Routes.Resource.Certificate, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCertificate>.Delete(ResourceCertificate requestParameters)
            => Execute(Routes.Resource.Certificate, Method.Delete, requestParameters);
    }
}