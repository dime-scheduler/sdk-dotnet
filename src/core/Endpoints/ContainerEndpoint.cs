using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public class ContainerEndpoint : DefaultEndpoint<Container>, IContainerEndpoint
    {
        public ContainerEndpoint(EndpointOptions opts)
            : base(Routes.Container, opts)
        {
        }
    }
}