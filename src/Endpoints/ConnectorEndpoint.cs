using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    internal class ConnectorEndpoint : DefaultEndpoint<Connector>, IConnectorEndpoint
    {
        internal ConnectorEndpoint(EndpointOptions opts) : base(Routes.Connector, opts)
        {
        }
    }
}