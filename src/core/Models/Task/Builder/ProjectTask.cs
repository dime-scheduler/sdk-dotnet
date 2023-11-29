using System;

namespace Dime.Scheduler.Entities.Builder
{
    public class ProjectTask
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int PercentDone { get; set; }
        public SchedulingMode SchedulingMode { get; set; }
        public DateTime? BaseLineStartDate { get; set; }
        public DateTime? BaseLineEndDate { get; set; }
        public int BaseLinePercentDone { get; set; }
        public DateTime? DeadLine { get; set; }
        public int Index { get; set; }
        public int ConstraintType { get; set; }
        public DateTime? ConstraintDatetime { get; set; }
        public string ParentTaskNo { get; set; }
        public string CalendarCode { get; set; }
        public string PredecessorTaskNo { get; set; }
        public int PredecessorLag { get; set; }
    }
}