using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.Sdk
{
    public class ConnectorEndpoint : DefaultEndpoint<Connector>, IConnectorEndpoint
    {
        public ConnectorEndpoint(AuthenticationOptions opts)
            : base(Routes.Connector, opts)
        {
        }
    }
}