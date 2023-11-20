using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.Sdk
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