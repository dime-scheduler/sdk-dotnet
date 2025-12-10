using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// Represents the scheduling mode for tasks.
    /// </summary>
    public enum SchedulingMode
    {
        /// <summary>
        /// Normal scheduling mode.
        /// </summary>
        [Description("Normal scheduling mode.")]
        Normal,
        /// <summary>
        /// Fixed duration scheduling mode.
        /// </summary>
        [Description("Fixed duration scheduling mode.")]
        FixedDuration,
        /// <summary>
        /// Effort-driven scheduling mode.
        /// </summary>
        [Description("Effort-driven scheduling mode.")]
        EffortDriven,
        /// <summary>
        /// Dynamic assignment scheduling mode.
        /// </summary>
        [Description("Dynamic assignment scheduling mode.")]
        DynamicAssignment
    }
}