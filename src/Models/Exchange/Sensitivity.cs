using System.ComponentModel;

namespace Dime.Scheduler.Entities.Exchange
{
    /// <summary>
    /// Represents the sensitivity level of an Exchange appointment.
    /// </summary>
    public enum Sensitivity
    {
        /// <summary>
        /// Normal sensitivity.
        /// </summary>
        [Description("Normal")]
        Normal = 1,

        /// <summary>
        /// Personal sensitivity.
        /// </summary>
        [Description("Personal")]
        Personal = 2,

        /// <summary>
        /// Private sensitivity.
        /// </summary>
        [Description("Private")]
        Private = 3,

        /// <summary>
        /// Confidential sensitivity.
        /// </summary>
        [Description("Confidential")]
        Confidential = 4
    }
}