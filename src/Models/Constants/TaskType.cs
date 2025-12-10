using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// Represents the type of task.
    /// </summary>
    public enum TaskType
    {
        /// <summary>
        /// Planning task.
        /// </summary>
        [Description("Planning task.")]
        Planning = 0,
        /// <summary>
        /// Project task.
        /// </summary>
        [Description("Project task.")]
        Project = 1
    }
}