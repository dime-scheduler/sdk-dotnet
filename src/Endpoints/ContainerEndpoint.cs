using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    internal class ContainerEndpoint : DefaultEndpoint<Container>, IContainerEndpoint
    {
        internal ContainerEndpoint(EndpointOptions opts) : base(Routes.Container, opts)
        {
        }
    }
}