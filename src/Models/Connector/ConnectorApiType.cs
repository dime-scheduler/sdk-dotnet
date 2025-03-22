using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    public enum ConnectorApiType
    {
        [Description("SOAP")]
        SOAP,
        [Description("REST")]
        REST
    }
}