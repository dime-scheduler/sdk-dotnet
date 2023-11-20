using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.Sdk
{
    public class ContainerEndpoint : DefaultEndpoint<Container>, IContainerEndpoint
    {
        public ContainerEndpoint(AuthenticationOptions opts)
            : base(Routes.Container, opts)
        {
        }
    }
}