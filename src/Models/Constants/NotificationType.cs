using System.ComponentModel;

namespace Dime.Scheduler
{
    /// <summary>
    /// Represents the type of notification.
    /// </summary>
    public enum NotificationType
    {
        /// <summary>
        /// Informational notification.
        /// </summary>
        [Description("Informational notification.")]
        Info = 0,
        /// <summary>
        /// Warning notification.
        /// </summary>
        [Description("Warning notification.")]
        Warning = 1,
        /// <summary>
        /// Error notification.
        /// </summary>
        [Description("Error notification.")]
        Error = 2
    }
}