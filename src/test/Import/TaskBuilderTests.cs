using System;
using Dime.Scheduler.Sdk.Import;
using Dime.Scheduler.Sdk.Import.Builder;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class TaskBuilderTests
    {
        [Fact]
        public void TaskBuilder_SetExtendables_ShouldMapProperties()
        {
            TaskBuilder taskBuilder = new();
            Task task = taskBuilder.WithExtendables(new Extendable
            {
                FreeText1 = "Free Text 1",
                FreeText2 = "Free Text 2",
                FreeText3 = "Free Text 3",
                FreeText4 = "Free Text 4",
                FreeText5 = "Free Text 5",
                FreeText6 = "Free Text 6",
                FreeText7 = "Free Text 7",
                FreeText8 = "Free Text 8",
                FreeText9 = "Free Text 9",
                FreeText10 = "Free Text 10",
                FreeText11 = "Free Text 11",
                FreeText12 = "Free Text 12",
                FreeText13 = "Free Text 13",
                FreeText14 = "Free Text 14",
                FreeText15 = "Free Text 15",
                FreeText16 = "Free Text 16",
                FreeText17 = "Free Text 17",
                FreeText18 = "Free Text 18",
                FreeText19 = "Free Text 19",
                FreeText20 = "Free Text 20",
                FreeBit1 = true,
                FreeBit2 = true,
                FreeBit3 = true,
                FreeBit4 = true,
                FreeBit5 = true,
                FreeDecimal1 = 18,
                FreeDecimal2 = 18,
                FreeDecimal3 = 18,
                FreeDecimal4 = 18,
                FreeDecimal5 = 18,
                FreeDate1 = new DateTime(2020, 1, 1),
                FreeDate2 = new DateTime(2020, 1, 1),
                FreeDate3 = new DateTime(2020, 1, 1),
                FreeDate4 = new DateTime(2020, 1, 1),
                FreeDate5 = new DateTime(2020, 1, 1)
            }).Create();

            Assert.True(task.FreeText1 == "Free Text 1");
        }

        [Fact]
        public void TaskBuilder_SetProject_ShouldMapProperties()
        {
            TaskBuilder taskBuilder = new();
            Task task = taskBuilder.WithProject(new ProjectTask()
            {
                BaseLineEndDate = new DateTime(2020, 1, 1),
                BaseLinePercentDone = 25,
                BaseLineStartDate = new DateTime(2020, 1, 2),
                CalendarCode = "CALENDAR_001",
                ConstraintDatetime = new DateTime(2020, 1, 3),
                ConstraintType = 3,
                DeadLine = new DateTime(2020, 1, 4),
                EndDate = new DateTime(2020, 1, 5),
                Index = 5,
                ParentTaskNo = "TASK_001",
                PercentDone = 50,
                PredecessorLag = 2,
                PredecessorTaskNo = "TASK_002",
                SchedulingMode = SchedulingMode.FixedDuration,
                StartDate = new DateTime(2020, 1, 6)
            }).Create();

            Assert.True(task.PredecessorTaskNo == "TASK_002");
        }

        [Fact]
        public void TaskBuilder_SetIris_ShouldMapProperties()
        {
            TaskBuilder taskBuilder = new();
            Task task = taskBuilder.WithIris(new InternationalRepairCodingSystem()
            {
                Reason = "Reason",
                Area = "Area",
                Fault = "Fault",
                Resolution = "Resolution",
                Symptom = "Symptom"
            }).Create();

            Assert.True(task.IrisArea == "Area");
        }

        [Fact]
        public void TaskBuilder_SetContract_ShouldMapProperties()
        {
            TaskBuilder taskBuilder = new();
            Task task = taskBuilder.WithContract(new Contract()
            {
                Description = "Description",
                StartDate = new DateTime(2020, 1, 1),
                EndDate = new DateTime(2020, 1, 3),
                Type = "Type",
                No = "No"
            }).Create();

            Assert.True(task.ContractDescription == "Description");
        }

        [Fact]
        public void TaskBuilder_SetService_ShouldMapProperties()
        {
            TaskBuilder taskBuilder = new();
            Task task = taskBuilder.WithService(new Service()
            {
                Name = "Name",
                Class = "Class",
                Group = "Group",
                No = "No",
                SerialNo = "SerialNo"
            }).Create();

            Assert.True(task.ServiceSerialNo == "SerialNo");
        }
    }
}