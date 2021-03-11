using System;

namespace Dime.Scheduler.Sdk.Import
{
    [Obsolete("Will be removed in version 2.x")]
    public class TaskBuilder : IImportRequestableBuilder<Task>
    {
        private readonly Task _task = new();

        public TaskBuilder WithProject(ProjectTask projectTask)
        {
            _task.BaseLineEndDate = projectTask.BaseLineEndDate;
            _task.BaseLineStartDate = projectTask.BaseLineStartDate;
            _task.ConstraintDatetime = projectTask.ConstraintDatetime;
            _task.DeadLine = projectTask.DeadLine;
            _task.EndDate = projectTask.EndDate;
            _task.StartDate = projectTask.StartDate;
            _task.BaseLinePercentDone = projectTask.BaseLinePercentDone;
            _task.CalendarCode = projectTask.CalendarCode;
            _task.ConstraintType = projectTask.ConstraintType;
            _task.Index = projectTask.Index;
            _task.ParentTaskNo = projectTask.ParentTaskNo;
            _task.PercentDone = projectTask.PercentDone;
            _task.PredecessorLag = projectTask.PredecessorLag;
            _task.PredecessorTaskNo = projectTask.PredecessorTaskNo;
            _task.SchedulingMode = projectTask.SchedulingMode;

            return this;
        }

        public TaskBuilder WithExtendables(Extendable extendable)
            => WithFreeTextExtendables(extendable)
                .WithFreeDateExtendables(extendable)
                .WithFreeDecimalExtendables(extendable)
                .WithFreeBooleanExtendables(extendable);

        private TaskBuilder WithFreeTextExtendables(Extendable extendable)
        {
            _task.FreeText1 = extendable.FreeText1;
            _task.FreeText2 = extendable.FreeText2;
            _task.FreeText3 = extendable.FreeText3;
            _task.FreeText4 = extendable.FreeText4;
            _task.FreeText5 = extendable.FreeText5;
            _task.FreeText6 = extendable.FreeText6;
            _task.FreeText7 = extendable.FreeText7;
            _task.FreeText8 = extendable.FreeText8;
            _task.FreeText9 = extendable.FreeText9;
            _task.FreeText10 = extendable.FreeText10;
            _task.FreeText11 = extendable.FreeText11;
            _task.FreeText12 = extendable.FreeText12;
            _task.FreeText13 = extendable.FreeText13;
            _task.FreeText14 = extendable.FreeText14;
            _task.FreeText15 = extendable.FreeText15;
            _task.FreeText16 = extendable.FreeText16;
            _task.FreeText17 = extendable.FreeText17;
            _task.FreeText18 = extendable.FreeText18;
            _task.FreeText19 = extendable.FreeText19;
            _task.FreeText20 = extendable.FreeText20;

            return this;
        }

        private TaskBuilder WithFreeDecimalExtendables(Extendable extendable)
        {

            _task.FreeDecimal1 = extendable.FreeDecimal1;
            _task.FreeDecimal2 = extendable.FreeDecimal2;
            _task.FreeDecimal3 = extendable.FreeDecimal3;
            _task.FreeDecimal4 = extendable.FreeDecimal4;
            _task.FreeDecimal5 = extendable.FreeDecimal5;

            return this;
        }

        private TaskBuilder WithFreeDateExtendables(Extendable extendable)
        {
            _task.FreeDate1 = extendable.FreeDate1;
            _task.FreeDate2 = extendable.FreeDate2;
            _task.FreeDate3 = extendable.FreeDate3;
            _task.FreeDate4 = extendable.FreeDate4;
            _task.FreeDate5 = extendable.FreeDate5;

            return this;
        }

        private TaskBuilder WithFreeBooleanExtendables(Extendable extendable)
        {
            _task.FreeBit1 = extendable.FreeBit1;
            _task.FreeBit2 = extendable.FreeBit2;
            _task.FreeBit3 = extendable.FreeBit3;
            _task.FreeBit4 = extendable.FreeBit4;
            _task.FreeBit5 = extendable.FreeBit5;

            return this;
        }

        public Task Create()
            => _task;
    }
}