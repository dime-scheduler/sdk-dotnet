using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public interface IResourceEndpoint :
        ICrudEndpoint<Resource>,
        ICrudEndpoint<ResourceFilterValue>,
        ICrudEndpoint<ResourceCalendar>,
        ICrudEndpoint<ResourceCapacity>,
        ICrudEndpoint<ResourceGpsTracking>,
        ICrudEndpoint<ResourceCertificate>
    {
    }
}