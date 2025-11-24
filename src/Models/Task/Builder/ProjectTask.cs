using System;

namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents a project task.
    /// </summary>
    public class ProjectTask
    {
        /// <summary>
        /// The start date.
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// The end date.
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// The percentage of completion.
        /// </summary>
        public int PercentDone { get; set; }
        /// <summary>
        /// The scheduling mode.
        /// </summary>
        public SchedulingMode SchedulingMode { get; set; }
        /// <summary>
        /// The baseline start date.
        /// </summary>
        public DateTime? BaseLineStartDate { get; set; }
        /// <summary>
        /// The baseline end date.
        /// </summary>
        public DateTime? BaseLineEndDate { get; set; }
        /// <summary>
        /// The baseline percentage of completion.
        /// </summary>
        public int BaseLinePercentDone { get; set; }
        /// <summary>
        /// The deadline date and time.
        /// </summary>
        public DateTime? DeadLine { get; set; }
        /// <summary>
        /// The index of the task.
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// The constraint type.
        /// </summary>
        public int ConstraintType { get; set; }
        /// <summary>
        /// The constraint date.
        /// </summary>
        public DateTime? ConstraintDate { get; set; }
        /// <summary>
        /// The parent task number.
        /// </summary>
        public string ParentTaskNo { get; set; }
        /// <summary>
        /// The calendar code.
        /// </summary>
        public string CalendarCode { get; set; }
        /// <summary>
        /// The predecessor task number.
        /// </summary>
        public string PredecessorTaskNo { get; set; }
        /// <summary>
        /// The predecessor lag time.
        /// </summary>
        public int PredecessorLag { get; set; }
    }
}