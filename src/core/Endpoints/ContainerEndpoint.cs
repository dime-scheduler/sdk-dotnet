namespace Dime.Scheduler.Sdk
{
    public class ContainerEndpoint : DefaultEndpoint<Import.Container>, IContainerEndpoint
    {
        public ContainerEndpoint(AuthenticationOptions opts)
            : base(Routes.Container, opts)
        {
        }
    }
}