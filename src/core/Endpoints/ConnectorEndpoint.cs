using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public class ConnectorEndpoint : DefaultEndpoint<Connector>, IConnectorEndpoint
    {
        public ConnectorEndpoint(EndpointOptions opts)
            : base(Routes.Connector, opts)
        {
        }
    }
}