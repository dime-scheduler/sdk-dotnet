using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// Represents the type of connector.
    /// </summary>
    public enum ConnectorType
    {
        /// <summary>
        /// No connector type specified.
        /// </summary>
        [Description("None")]
        None,
        /// <summary>
        /// Microsoft Dynamics 365 Business Central connector.
        /// </summary>
        [Description("Microsoft Dynamics 365 Business Central")]
        Bc,
        /// <summary>
        /// Microsoft Dynamics NAV connector.
        /// </summary>
        [Description("Microsoft Dynamics NAV")]
        Nav,
        /// <summary>
        /// Webhook connector.
        /// </summary>
        [Description("Webhook")]
        Webhook
    }
}