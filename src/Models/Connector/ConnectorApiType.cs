using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// Represents the API type for a connector.
    /// </summary>
    public enum ConnectorApiType
    {
        /// <summary>
        /// SOAP API type.
        /// </summary>
        [Description("SOAP")]
        SOAP,
        /// <summary>
        /// REST API type.
        /// </summary>
        [Description("REST")]
        REST
    }
}