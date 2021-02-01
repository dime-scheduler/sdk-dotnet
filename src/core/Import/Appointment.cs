using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace Dime.Scheduler.Sdk.Import
{
    public class Appointment : IImportRequestable
    {
        public long AppointmentId { get; set; }
        public Guid AppointmentGuid { get; set; }
        public string SourceApp { get; set; }
        public string SourceType { get; set; }
        public string JobNo { get; set; }
        public string TaskNo { get; set; }
        public string ResourceNo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsAllDay { get; set; }

        public string TimeMarker { get; set; }
        public string Category { get; set; }
        public int Importance { get; set; }
        public bool Locked { get; set; }
        public bool ReplaceResource { get; set; }
        public string BackOfficeId { get; set; }
        public string BackOfficeParentId { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal UnitOfMeasureConversion { get; set; }
        public decimal PlanningQuantity { get; set; }
        public bool UseFixedPlanningQuantity { get; set; }
        public bool RoundToUnitOfMeasure { get; set; }
        public bool SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        ImportRequest CreateAppendRequest() => new(
            "mboc_upsertAppointment",
            new List<string>()
            {
                "SourceApp",
                "SourceType",
                "AppointmentId",
                "JobNo",
                "TaskNo",
                "Subject",
                "Body",
                "Start",
                "End",
                "IsAllDayEvent",
                "TimeMarker",
                "Category",
                "Importance",
                "Locked",
                "ResourceNo",
                "AppointmentGuid",
                "ReplaceResource",
                "SentFromBackOffice",
                "BackOfficeID",
                "BackOfficeParentID",
                "PlanningUOM",
                "PlanningUOMConversion",
                "PlanningQty",
                "RoundToUOM"
            }.ToArray(),
            new List<string>()
            {
                SourceApp,
                SourceType,
                AppointmentId.ToString(),
                JobNo,
                TaskNo,
                Subject,
                Body,
                Start.ToString("s"),
                End.ToString("s"),
                IsAllDay.ToBit().ToString(),
                TimeMarker,
                Category,
                Importance.ToString(),
                Locked.ToBit().ToString(),
                ResourceNo,
                AppointmentGuid.ToString(),
                ReplaceResource.ToBit().ToString(),
                BackOfficeId,
                BackOfficeParentId,
                UnitOfMeasure,
                UnitOfMeasureConversion.ToString(),
                PlanningQuantity.ToString(),
                UseFixedPlanningQuantity.ToBit().ToString(),
                RoundToUnitOfMeasure.ToBit().ToString()
            }.ToArray());

        ImportRequest CreateDeleteRequest() => new(
            "mboc_deleteAppointment",
        new List<string> { "SourceApp", "SourceType", "AppointmentId", "ResourceNo", "AppointmentGuid", "SentFromBackOffice" }.ToArray(),
        new List<string> { SourceApp, SourceType, AppointmentId.ToString(), ResourceNo, AppointmentGuid.ToString(), SentFromBackOffice.ToBit().ToString() }.ToArray()
            );
    }
}