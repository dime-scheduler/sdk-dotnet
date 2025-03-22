using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    public enum ConnectorType
    {
        [Description("None")]
        None,
        [Description("Microsoft Dynamics 365 Business Central")]
        Bc,
        [Description("Microsoft Dynamics NAV")]
        Nav,
        [Description("Webhook")]
        Webhook
    }
}