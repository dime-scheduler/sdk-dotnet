namespace Dime.Scheduler.Sdk
{
    public interface IResourceEndpointService : IReadService<ResourceRequest, Resource>, IEndpointCrudService<ResourceRequest>
    {
    }
}