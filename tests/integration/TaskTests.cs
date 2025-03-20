﻿using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class TaskTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public TaskTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task Task()
        {
            Task model = new()
            {
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                JobNo = EntityNos.Job,
                TaskNo = EntityNos.Task,
                SentFromBackOffice = true,
                Name = "Name",
                Category = "Cat",
                Importance = Importance.High,
                StartDate = new DateTime(2020, 1, 1, 15, 30, 15),
                Type = "1",
                Description = "Desc",
                TimeMarker = "TM",
                Subject = "Sub",
                Body = "Body",
                EndDate = new DateTime(2020, 1, 1, 17, 30, 15),
                CalendarCode = "CODE",
                ActualEndDate = new DateTime(2020, 1, 1),
                ActualResponseDateTime = new DateTime(2020, 1, 1),
                ActualStartDate = new DateTime(2020, 1, 1),
                AppointmentEarliestAllowed = new DateTime(2020, 1, 1),
                AppointmentLatestAllowed = new DateTime(2020, 1, 2),
                AppointmentTemplate = "TP",
                BaseLineEndDate = new DateTime(2020, 1, 1, 15, 30, 15),
                BaseLinePercentDone = 25,
                BaseLineStartDate = new DateTime(2020, 1, 1, 12, 30, 15),
                BulkPlanningQty = 500,
                CertificateNo = "CERT",
                CheckAppointments = true,
                ConfirmedEndDate = new DateTime(2020, 1, 1),
                ConfirmedStartDate = new DateTime(2020, 1, 1),
                ConstraintDate = new DateTime(2020, 1, 1, 15, 30, 15),
                ConstraintType = 5,
                ContainerIndex = 1,
                ContainerName = "NAME",
                ContractDescription = "DESC",
                ContractEndDate = new DateTime(2020, 1, 1),
                ContractNo = "NO",
                ContractStartDate = new DateTime(2020, 1, 1),
                ContractType = "TYPE",
                DeadLine = new DateTime(2020, 1, 1, 15, 30, 15),
                DoNotCountAppointmentResource = true,
                Duration = new TimeSpan(1, 1, 1, 0),
                DurationInSeconds = 50000,
                ExpectedResponseDateTime = new DateTime(2020, 1, 1),
                FreeBit1 = true,
                FreeBit2 = true,
                FreeBit3 = true,
                FreeBit4 = true,
                FreeBit5 = true,
                FreeDate1 = new DateTime(2020, 1, 1),
                FreeDate2 = new DateTime(2020, 1, 1),
                FreeDate3 = new DateTime(2020, 1, 1),
                FreeDate4 = new DateTime(2020, 1, 1),
                FreeDate5 = new DateTime(2020, 1, 1),
                FreeDecimal1 = 1,
                FreeDecimal2 = 2,
                FreeDecimal3 = 3,
                FreeDecimal4 = 4,
                FreeDecimal5 = 5,
                FreeText1 = "Text",
                FreeText10 = "Text",
                FreeText11 = "Text",
                FreeText12 = "Text",
                FreeText13 = "Text",
                FreeText14 = "Text",
                FreeText15 = "Text",
                FreeText16 = "Text",
                FreeText17 = "Text",
                FreeText18 = "Text",
                FreeText19 = "Text",
                FreeText2 = "Text",
                FreeText20 = "Text",
                FreeText3 = "Text",
                FreeText4 = "Text",
                FreeText5 = "Text",
                FreeText6 = "Text",
                FreeText7 = "Text",
                FreeText8 = "Text",
                FreeText9 = "Text",
                IrisArea = "AREA",
                IrisFault = "FAULT",
                IrisReason = "REASON",
                IrisResolution = "RESOLUTION",
                IrisSymptom = "SYMPTON",
                IgnoreCalendars = true,
                Index = 1,
                InfiniteTask = true,
                IsComplete = false,
                LaborWarrantyEndDate = new DateTime(2020, 1, 1),
                LaborWarrantyStartDate = new DateTime(2020, 1, 1),
                LocationDescription = "DESC",
                ManuallyScheduled = true,
                Note = "NOTE",
                OverRuleGanttPlanning = true,
                ParentTaskNo = "TPARENT",
                PartsWarrantyEndDate = new DateTime(2020, 1, 1),
                PartsWarrantyStartDate = new DateTime(2020, 1, 1),
                PercentDone = 13,
                Pin = "PIN",
                PlanningQty = 500.21M,
                PlanningUOM = "UOM",
                PlanningUOMConversion = 25,
                PredecessorLag = 9,
                PredecessorTaskNo = "TASK",
                RequestedEndDate = new DateTime(2020, 1, 2),
                RequestedEndTime = new TimeSpan(1, 1, 1, 0),
                RequestedStartDate = new DateTime(2020, 1, 1),
                RequestedStartTime = new TimeSpan(1, 1, 1, 0),
                RequiredNoResources = 1,
                RequiredTotalDuration = new TimeSpan(1, 0, 1, 5),
                RequiredTotalDurationInSeconds = 100,
                RoundToUOM = true,
                SchedulingMode = SchedulingMode.FixedDuration,
                ServiceClass = "CLASS",
                ServiceGroup = "GROUP",
                ServiceName = "NAME",
                ServiceNo = "NO",
                ServiceSerialNo = "SERIAL",
                ShortDescription = "DESc",
                Skill1 = "SKILL",
                Skill2 = "SKILL",
                Skill3 = "SKILL",
                Status = "STATUS",
                TaskOpenAsOf = new DateTime(2020, 1, 1),
                TaskOpenTill = new DateTime(2020, 1, 1),
                TaskType = TaskType.Project,
                Url1 = "URL",
                Url2 = "URL",
                Url3 = "URL",
                UrlDescription1 = "URL DESC",
                UrlDescription2 = "URL DESC",
                UrlDescription3 = "URL DESC",
                UseFixPlanningQty = true,
                CreateJob = true
            };

            Result response = await _dimeSchedulerClientFixture.Client.Tasks.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}