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
        Normal,
        /// <summary>
        /// Fixed duration scheduling mode.
        /// </summary>
        FixedDuration,
        /// <summary>
        /// Effort-driven scheduling mode.
        /// </summary>
        EffortDriven,
        /// <summary>
        /// Dynamic assignment scheduling mode.
        /// </summary>
        DynamicAssignment
    }
}