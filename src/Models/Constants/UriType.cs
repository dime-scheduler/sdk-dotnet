using System.ComponentModel;

namespace Dime.Scheduler
{
    /// <summary>
    /// Represents the type of URI.
    /// </summary>
    public enum UriType
    {
        /// <summary>
        /// Planning board URI.
        /// </summary>
        [Description("Planning board URI.")]
        PlanningBoard = 0,
        /// <summary>
        /// Appointment URI.
        /// </summary>
        [Description("Appointment URI.")]
        Appointment = 1,
        /// <summary>
        /// Task URI.
        /// </summary>
        [Description("Task URI.")]
        Task = 2,
        /// <summary>
        /// Map URI.
        /// </summary>
        [Description("Map URI.")]
        Map = 3
    }
}