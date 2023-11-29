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

        void ICrudEndpoint<Resource>.Create(Resource requestParameters)
            => Execute(Routes.Resource.Entity, Method.Post, requestParameters);

        t.Task ICrudEndpoint<Resource>.CreateAsync(Resource requestParameters)
            => ExecuteAsync(Routes.Resource.Entity, Method.Post, requestParameters);

        void ICrudEndpoint<Resource>.Update(Resource requestParameters)
          => Execute(Routes.Resource.Entity, Method.Post, requestParameters);

        t.Task ICrudEndpoint<Resource>.UpdateAsync(Resource requestParameters)
          => ExecuteAsync(Routes.Resource.Entity, Method.Post, requestParameters);

        void ICrudEndpoint<Resource>.Delete(Resource requestParameters)
            => Execute(Routes.Resource.Entity, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<Resource>.DeleteAsync(Resource requestParameters)
            => ExecuteAsync(Routes.Resource.Entity, Method.Delete, requestParameters);

        void ICrudEndpoint<ResourceFilterValue>.Create(ResourceFilterValue requestParameters)
            => Execute(Routes.Resource.FilterValue, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceFilterValue>.CreateAsync(ResourceFilterValue requestParameters)
            => ExecuteAsync(Routes.Resource.FilterValue, Method.Post, requestParameters);

        void ICrudEndpoint<ResourceFilterValue>.Update(ResourceFilterValue requestParameters)
         => Execute(Routes.Resource.FilterValue, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceFilterValue>.UpdateAsync(ResourceFilterValue requestParameters)
           => ExecuteAsync(Routes.Resource.FilterValue, Method.Post, requestParameters);

        void ICrudEndpoint<ResourceFilterValue>.Delete(ResourceFilterValue requestParameters)
        => Execute(Routes.Resource.FilterValue, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<ResourceFilterValue>.DeleteAsync(ResourceFilterValue requestParameters)
            => ExecuteAsync(Routes.Resource.FilterValue, Method.Delete, requestParameters);

        void ICrudEndpoint<ResourceCalendar>.Create(ResourceCalendar requestParameters)
            => ExecuteAsync(Routes.Resource.Calendar, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCalendar>.CreateAsync(ResourceCalendar requestParameters)
            => ExecuteAsync(Routes.Resource.Calendar, Method.Post, requestParameters);

        void ICrudEndpoint<ResourceCalendar>.Update(ResourceCalendar requestParameters)
        => ExecuteAsync(Routes.Resource.Calendar, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCalendar>.UpdateAsync(ResourceCalendar requestParameters)
         => ExecuteAsync(Routes.Resource.Calendar, Method.Post, requestParameters);

        void ICrudEndpoint<ResourceCalendar>.Delete(ResourceCalendar requestParameters)
            => Execute(Routes.Resource.Calendar, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<ResourceCalendar>.DeleteAsync(ResourceCalendar requestParameters)
           => ExecuteAsync(Routes.Resource.Calendar, Method.Delete, requestParameters);

        void ICrudEndpoint<ResourceCapacity>.Create(ResourceCapacity requestParameters)
            => Execute(Routes.Resource.Capacity, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCapacity>.CreateAsync(ResourceCapacity requestParameters)
            => ExecuteAsync(Routes.Resource.Capacity, Method.Post, requestParameters);

        void ICrudEndpoint<ResourceCapacity>.Update(ResourceCapacity requestParameters)
           => Execute(Routes.Resource.Capacity, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCapacity>.UpdateAsync(ResourceCapacity requestParameters)
            => ExecuteAsync(Routes.Resource.Capacity, Method.Post, requestParameters);

        void ICrudEndpoint<ResourceCapacity>.Delete(ResourceCapacity requestParameters)
        => Execute(Routes.Resource.Capacity, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<ResourceCapacity>.DeleteAsync(ResourceCapacity requestParameters)
           => ExecuteAsync(Routes.Resource.Capacity, Method.Delete, requestParameters);

        void ICrudEndpoint<ResourceGpsTracking>.Create(ResourceGpsTracking requestParameters)
             => ExecuteAsync(Routes.Resource.GpsTracking, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceGpsTracking>.CreateAsync(ResourceGpsTracking requestParameters)
            => ExecuteAsync(Routes.Resource.GpsTracking, Method.Post, requestParameters);

        void ICrudEndpoint<ResourceGpsTracking>.Update(ResourceGpsTracking requestParameters)
         => ExecuteAsync(Routes.Resource.GpsTracking, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceGpsTracking>.UpdateAsync(ResourceGpsTracking requestParameters)
           => ExecuteAsync(Routes.Resource.GpsTracking, Method.Post, requestParameters);

        void ICrudEndpoint<ResourceGpsTracking>.Delete(ResourceGpsTracking requestParameters)
         => ExecuteAsync(Routes.Resource.GpsTracking, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<ResourceGpsTracking>.DeleteAsync(ResourceGpsTracking requestParameters)
            => ExecuteAsync(Routes.Resource.GpsTracking, Method.Delete, requestParameters);

        void ICrudEndpoint<ResourceCertificate>.Create(ResourceCertificate requestParameters)
            => ExecuteAsync(Routes.Resource.Certificate, Method.Post, requestParameters);

        void ICrudEndpoint<ResourceCertificate>.Update(ResourceCertificate requestParameters)
            => ExecuteAsync(Routes.Resource.Certificate, Method.Post, requestParameters);

        void ICrudEndpoint<ResourceCertificate>.Delete(ResourceCertificate requestParameters)
            => ExecuteAsync(Routes.Resource.Certificate, Method.Delete, requestParameters);

        t.Task ICrudEndpoint<ResourceCertificate>.CreateAsync(ResourceCertificate requestParameters)
            => ExecuteAsync(Routes.Resource.Certificate, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCertificate>.UpdateAsync(ResourceCertificate requestParameters)
            => ExecuteAsync(Routes.Resource.Certificate, Method.Post, requestParameters);

        t.Task ICrudEndpoint<ResourceCertificate>.DeleteAsync(ResourceCertificate requestParameters)
            => ExecuteAsync(Routes.Resource.Certificate, Method.Delete, requestParameters);
    }
}