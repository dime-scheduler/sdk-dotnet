using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// Represents the importance level of an item.
    /// </summary>
    public enum Importance
    {
        /// <summary>
        /// Low importance.
        /// </summary>
        [Description("Low importance.")]
        Low = 2,
        /// <summary>
        /// Medium importance.
        /// </summary>
        [Description("Medium importance.")]
        Medium = 0,
        /// <summary>
        /// High importance.
        /// </summary>
        [Description("High importance.")]
        High = 1
    }
}