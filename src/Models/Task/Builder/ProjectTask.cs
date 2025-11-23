using System;

namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents a project task.
    /// </summary>
    public class ProjectTask
    {
        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Gets or sets the percentage of completion.
        /// </summary>
        public int PercentDone { get; set; }
        /// <summary>
        /// Gets or sets the scheduling mode.
        /// </summary>
        public SchedulingMode SchedulingMode { get; set; }
        /// <summary>
        /// Gets or sets the baseline start date.
        /// </summary>
        public DateTime? BaseLineStartDate { get; set; }
        /// <summary>
        /// Gets or sets the baseline end date.
        /// </summary>
        public DateTime? BaseLineEndDate { get; set; }
        /// <summary>
        /// Gets or sets the baseline percentage of completion.
        /// </summary>
        public int BaseLinePercentDone { get; set; }
        /// <summary>
        /// Gets or sets the deadline date and time.
        /// </summary>
        public DateTime? DeadLine { get; set; }
        /// <summary>
        /// Gets or sets the index of the task.
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// Gets or sets the constraint type.
        /// </summary>
        public int ConstraintType { get; set; }
        /// <summary>
        /// Gets or sets the constraint date.
        /// </summary>
        public DateTime? ConstraintDate { get; set; }
        /// <summary>
        /// Gets or sets the parent task number.
        /// </summary>
        public string ParentTaskNo { get; set; }
        /// <summary>
        /// Gets or sets the calendar code.
        /// </summary>
        public string CalendarCode { get; set; }
        /// <summary>
        /// Gets or sets the predecessor task number.
        /// </summary>
        public string PredecessorTaskNo { get; set; }
        /// <summary>
        /// Gets or sets the predecessor lag time.
        /// </summary>
        public int PredecessorLag { get; set; }
    }
}