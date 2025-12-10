using System.ComponentModel;

namespace Dime.Scheduler
{
    /// <summary>
    /// Represents the severity level of a message or log entry.
    /// </summary>
    public enum Severity
    {
        /// <summary>
        /// Verbose severity level.
        /// </summary>
        [Description("Verbose severity level.")]
        Verbose,
        /// <summary>
        /// Debug severity level.
        /// </summary>
        [Description("Debug severity level.")]
        Debug,
        /// <summary>
        /// Information severity level.
        /// </summary>
        [Description("Information severity level.")]
        Info,
        /// <summary>
        /// Warning severity level.
        /// </summary>
        [Description("Warning severity level.")]
        Warning,
        /// <summary>
        /// Error severity level.
        /// </summary>
        [Description("Error severity level.")]
        Error,
        /// <summary>
        /// Fatal severity level.
        /// </summary>
        [Description("Fatal severity level.")]
        Fatal
    }
}