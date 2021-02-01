using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class Task : IImportRequestable
    {
        public string SourceApp { get; set; }
        public string SourceType { get; set; }
        public string JobNo { get; set; }
        public string TaskNo { get; set; }
        public string TaskType { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string TimeMarker { get; set; }
        public string Pin { get; set; }
        public string ServiceNo { get; set; }
        public string ServiceGroup { get; set; }
        public string ServiceClass { get; set; }
        public string ServiceSerialNo { get; set; }
        public string ServiceName { get; set; }
        public string IRISFault { get; set; }
        public string IRISSymptom { get; set; }
        public string IRISArea { get; set; }
        public string IRISReason { get; set; }
        public string IRISResolution { get; set; }
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Skill3 { get; set; }
        public string ContractNo { get; set; }
        public string ContractType { get; set; }
        public string ContractDescription { get; set; }
        public string ContractStartDate { get; set; }
        public string ContractEndDate { get; set; }
        public string PartsWarrantyStartDate { get; set; }
        public string PartsWarrantyEndDate { get; set; }
        public string LaborWarrantyStartDate { get; set; }
        public string LaborWarrantyEndDate { get; set; }
        public string Importance { get; set; }
        public string Status { get; set; }
        public string ExpectedResponseDateTime { get; set; }
        public string ActualResponseDateTime { get; set; }
        public string RequestedStartDatetime { get; set; }
        public string RequestedEndDatetime { get; set; }
        public string ConfirmedStartDatetime { get; set; }
        public string ConfirmedEndDatetime { get; set; }
        public string ActualStartDatetime { get; set; }
        public string ActualEndDatetime { get; set; }
        public string LocationDescription { get; set; }
        public string Duration { get; set; }
        public string DurationInSeconds { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string InfiniteTask { get; set; }
        public string TaskOpenAsOftime { get; set; }
        public string TaskOpenTilltime { get; set; }
        public string RequiredTotalDuration { get; set; }
        public string RequiredNoResources { get; set; }
        public string AppointmentEarliestAllowedtime { get; set; }
        public string AppointmentLatestAllowedtime { get; set; }
        public string FreeText1 { get; set; }
        public string FreeText2 { get; set; }
        public string FreeText3 { get; set; }
        public string FreeText4 { get; set; }
        public string FreeText5 { get; set; }
        public string FreeText6 { get; set; }
        public string FreeText7 { get; set; }
        public string FreeText8 { get; set; }
        public string FreeText9 { get; set; }
        public string FreeText10 { get; set; }
        public string FreeText11 { get; set; }
        public string FreeText12 { get; set; }
        public string FreeText13 { get; set; }
        public string FreeText14 { get; set; }
        public string FreeText15 { get; set; }
        public string FreeText16 { get; set; }
        public string FreeText17 { get; set; }
        public string FreeText18 { get; set; }
        public string FreeText19 { get; set; }
        public string FreeText20 { get; set; }
        public string FreeDecimal1 { get; set; }
        public string FreeDecimal2 { get; set; }
        public string FreeDecimal3 { get; set; }
        public string FreeDecimal4 { get; set; }
        public string FreeDecimal5 { get; set; }
        public string FreeDate1time { get; set; }
        public string FreeDate2time { get; set; }
        public string FreeDate3time { get; set; }
        public string FreeDate4time { get; set; }
        public string FreeDate5time { get; set; }
        public string FreeBit1 { get; set; }
        public string FreeBit2 { get; set; }
        public string FreeBit3 { get; set; }
        public string FreeBit4 { get; set; }
        public string FreeBit5 { get; set; }
        public string url1 { get; set; }
        public string urldesc1 { get; set; }
        public string url2 { get; set; }
        public string urldesc2 { get; set; }
        public string url3 { get; set; }
        public string urldesc3 { get; set; }
        public string CertificateNo { get; set; }
        public string RequiredTotalDurationInSeconds { get; set; }
        public string DoNotCountAppointmentResource { get; set; }
        public string IsComplete { get; set; }
        public string PlanningUOM { get; set; }
        public string PlanningUOMConversion { get; set; }
        public string PlanningQty { get; set; }
        public string UseFixPlanningQty { get; set; }
        public string RoundToUOM { get; set; }
        public string AppointmentTemplate { get; set; }
        public string BulkPlanningQty { get; set; }
        public string StartDatetime { get; set; }
        public string EndDatetime { get; set; }
        public string PercentDone { get; set; }
        public string SchedulingMode { get; set; }
        public string BaseLineStartDatetime { get; set; }
        public string BaseLineEndDatetime { get; set; }
        public string BaseLinePercentDone { get; set; }
        public string DeadLinetime { get; set; }
        public string Index { get; set; }
        public string ConstraintType { get; set; }
        public string ConstraintDatetime { get; set; }
        public string ParentTaskNo { get; set; }
        public string CalendarCode { get; set; }
        public string PredecessorTaskNo { get; set; }
        public string PredecessorLag { get; set; }
        public string ManuallyScheduled { get; set; }
        public string Note { get; set; }
        public string OverRuleGanttPlanning { get; set; }
        public string IgnoreCalendars { get; set; }
        public string ContainerName { get; set; }
        public string ContainerIndex { get; set; }
        public bool CheckAppointments { get; set; }
        public bool SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        ImportRequest CreateAppendRequest()
        => new(
            "mboc_upsertTask",
            new List<string>
            {
                "SourceApp",
                "SourceType",
                "JobNo",
                "TaskNo",
                "TaskType",
                "ShortDescription",
                "Description",
                "Name",
                "Type",
                "Category",
                "TimeMarker",
                "Pin",
                "ServiceNo",
                "ServiceGroup",
                "ServiceClass",
                "ServiceSerialNo",
                "ServiceName",
                "IRISFault",
                "IRISSymptom",
                "IRISArea",
                "IRISReason",
                "IRISResolution",
                "Skill1",
                "Skill2",
                "Skill3",
                "ContractNo",
                "ContractType",
                "ContractDescription",
                "ContractStartDate",
                "ContractEndDate",
                "PartsWarrantyStartDate",
                "PartsWarrantyEndDate",
                "LaborWarrantyStartDate",
                "LaborWarrantyEndDate",
                "Importance",
                "Status",
                "ExpectedResponseDateTime",
                "ActualResponseDateTime",
                "RequestedStartDatetime",
                "RequestedEndDatetime",
                "ConfirmedStartDatetime",
                "ConfirmedEndDatetime",
                "ActualStartDatetime",
                "ActualEndDatetime",
                "LocationDescription",
                "Duration",
                "DurationInSeconds",
                "Subject",
                "Body",
                "InfiniteTask",
                "TaskOpenAsOftime",
                "TaskOpenTilltime",
                "RequiredTotalDuration",
                "RequiredNoResources",
                "AppointmentEarliestAllowedtime",
                "AppointmentLatestAllowedtime",
                "FreeText1",
                "FreeText2",
                "FreeText3",
                "FreeText4",
                "FreeText5",
                "FreeText6",
                "FreeText7",
                "FreeText8",
                "FreeText9",
                "FreeText10",
                "FreeText11",
                "FreeText12",
                "FreeText13",
                "FreeText14",
                "FreeText15",
                "FreeText16",
                "FreeText17",
                "FreeText18",
                "FreeText19",
                "FreeText20",
                "FreeDecimal1",
                "FreeDecimal2",
                "FreeDecimal3",
                "FreeDecimal4",
                "FreeDecimal5",
                "FreeDate1time",
                "FreeDate2time",
                "FreeDate3time",
                "FreeDate4time",
                "FreeDate5time",
                "FreeBit1",
                "FreeBit2",
                "FreeBit3",
                "FreeBit4",
                "FreeBit5",
                "url1",
                "urldesc1",
                "url2",
                "urldesc2",
                "url3",
                "urldesc3",
                "CertificateNo",
                "RequiredTotalDurationInSeconds",
                "DoNotCountAppointmentResource",
                "IsComplete",
                "PlanningUOM",
                "PlanningUOMConversion",
                "PlanningQty",
                "UseFixPlanningQty",
                "RoundToUOM",
                "AppointmentTemplate",
                "BulkPlanningQty",
                "StartDatetime",
                "EndDatetime",
                "PercentDone",
                "SchedulingMode",
                "BaseLineStartDatetime",
                "BaseLineEndDatetime",
                "BaseLinePercentDone",
                "DeadLinetime",
                "Index",
                "ConstraintType",
                "ConstraintDatetime",
                "ParentTaskNo",
                "CalendarCode",
                "PredecessorTaskNo",
                "PredecessorLag",
                "ManuallyScheduled",
                "Note",
                "OverRuleGanttPlanning",
                "IgnoreCalendars",
                "ContainerName",
                "ContainerIndex",
            }.ToArray(),
            new List<string>
            {
                SourceApp,
                SourceType,
                JobNo,
                TaskNo,
                TaskType,
                ShortDescription,
                Description,
                Name,
                Type,
                Category,
                TimeMarker,
                Pin,
                ServiceNo,
                ServiceGroup,
                ServiceClass,
                ServiceSerialNo,
                ServiceName,
                IRISFault,
                IRISSymptom,
                IRISArea,
                IRISReason,
                IRISResolution,
                Skill1,
                Skill2,
                Skill3,
                ContractNo,
                ContractType,
                ContractDescription,
                ContractStartDate,
                ContractEndDate,
                PartsWarrantyStartDate,
                PartsWarrantyEndDate,
                LaborWarrantyStartDate,
                LaborWarrantyEndDate,
                Importance,
                Status,
                ExpectedResponseDateTime,
                ActualResponseDateTime,
                RequestedStartDatetime,
                RequestedEndDatetime,
                ConfirmedStartDatetime,
                ConfirmedEndDatetime,
                ActualStartDatetime,
                ActualEndDatetime,
                LocationDescription,
                Duration,
                DurationInSeconds,
                Subject,
                Body,
                InfiniteTask,
                TaskOpenAsOftime,
                TaskOpenTilltime,
                RequiredTotalDuration,
                RequiredNoResources,
                AppointmentEarliestAllowedtime,
                AppointmentLatestAllowedtime,
                FreeText1,
                FreeText2,
                FreeText3,
                FreeText4,
                FreeText5,
                FreeText6,
                FreeText7,
                FreeText8,
                FreeText9,
                FreeText10,
                FreeText11,
                FreeText12,
                FreeText13,
                FreeText14,
                FreeText15,
                FreeText16,
                FreeText17,
                FreeText18,
                FreeText19,
                FreeText20,
                FreeDecimal1,
                FreeDecimal2,
                FreeDecimal3,
                FreeDecimal4,
                FreeDecimal5,
                FreeDate1time,
                FreeDate2time,
                FreeDate3time,
                FreeDate4time,
                FreeDate5time,
                FreeBit1,
                FreeBit2,
                FreeBit3,
                FreeBit4,
                FreeBit5,
                url1,
                urldesc1,
                url2,
                urldesc2,
                url3,
                urldesc3,
                CertificateNo,
                RequiredTotalDurationInSeconds,
                DoNotCountAppointmentResource,
                IsComplete,
                PlanningUOM,
                PlanningUOMConversion,
                PlanningQty,
                UseFixPlanningQty,
                RoundToUOM,
                AppointmentTemplate,
                BulkPlanningQty,
                StartDatetime,
                EndDatetime,
                PercentDone,
                SchedulingMode,
                BaseLineStartDatetime,
                BaseLineEndDatetime,
                BaseLinePercentDone,
                DeadLinetime,
                Index,
                ConstraintType,
                ConstraintDatetime,
                ParentTaskNo,
                CalendarCode,
                PredecessorTaskNo,
                PredecessorLag,
                ManuallyScheduled,
                Note,
                OverRuleGanttPlanning,
                IgnoreCalendars,
                ContainerName,
                ContainerIndex
            }.ToArray());

        ImportRequest CreateDeleteRequest() => new(
            "mboc_deleteTask",
            new List<string> { "SourceApp", "SourceType", "JobNo", "TaskNo", "CheckAppointments", "SentFromBackOffice" }.ToArray(),
            new List<string> { SourceApp, SourceType, JobNo, TaskNo, CheckAppointments.ToBit().ToString(), SentFromBackOffice.ToBit().ToString() }.ToArray()
        );

    }
}
