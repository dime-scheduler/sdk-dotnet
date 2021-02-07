using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Task : IImportRequestable, IValidatableImportRequest<Task>
    {
        [Required]
        [MaxLength(30)]
        [ImportParameter(nameof(SourceApp), TransactionType.Append, TransactionType.Delete)]
        public string SourceApp { get; set; }

        [Required]
        [MaxLength(10)]
        [ImportParameter(nameof(SourceType), TransactionType.Append, TransactionType.Delete)]
        public string SourceType { get; set; }

        [Required]
        [MaxLength(50)]
        [ImportParameter(nameof(JobNo), TransactionType.Append, TransactionType.Delete)]
        public string JobNo { get; set; }

        [Required]
        [ImportParameter(nameof(TaskNo), TransactionType.Append)]
        public string TaskNo { get; set; }

        [ImportParameter(nameof(TaskType), TransactionType.Append)]
        public int TaskType { get; set; }

        [ImportParameter(nameof(ShortDescription), TransactionType.Append)]
        public string ShortDescription { get; set; }

        [ImportParameter(nameof(Description), TransactionType.Append)]
        [MaxLength(50)]
        public string Description { get; set; }

        [ImportParameter(nameof(Name), TransactionType.Append)]
        public string Name { get; set; }

        [ImportParameter(nameof(Type), TransactionType.Append)]
        public string Type { get; set; }

        [ImportParameter(nameof(Category), TransactionType.Append)]
        public string Category { get; set; }

        [ImportParameter(nameof(TimeMarker), TransactionType.Append)]
        public string TimeMarker { get; set; }

        [ImportParameter(nameof(Pin), TransactionType.Append)]
        public string Pin { get; set; }

        [ImportParameter(nameof(ServiceNo), TransactionType.Append)]
        public string ServiceNo { get; set; }

        [ImportParameter(nameof(ServiceGroup), TransactionType.Append)]
        public string ServiceGroup { get; set; }

        [ImportParameter(nameof(ServiceClass), TransactionType.Append)]
        public string ServiceClass { get; set; }

        [ImportParameter(nameof(ServiceSerialNo), TransactionType.Append)]
        public string ServiceSerialNo { get; set; }

        [ImportParameter(nameof(ServiceName), TransactionType.Append)]
        public string ServiceName { get; set; }

        [ImportParameter(nameof(IRISFault), TransactionType.Append)]
        public string IRISFault { get; set; }

        [ImportParameter(nameof(IRISSymptom), TransactionType.Append)]
        public string IRISSymptom { get; set; }

        [ImportParameter(nameof(IRISArea), TransactionType.Append)]
        public string IRISArea { get; set; }

        [ImportParameter(nameof(IRISReason), TransactionType.Append)]
        public string IRISReason { get; set; }

        [ImportParameter(nameof(IRISResolution), TransactionType.Append)]
        public string IRISResolution { get; set; }

        [ImportParameter(nameof(Skill1), TransactionType.Append)]
        public string Skill1 { get; set; }

        [ImportParameter(nameof(Skill2), TransactionType.Append)]
        public string Skill2 { get; set; }

        [ImportParameter(nameof(Skill3), TransactionType.Append)]
        public string Skill3 { get; set; }

        [ImportParameter(nameof(ContractNo), TransactionType.Append)]
        public string ContractNo { get; set; }

        [ImportParameter(nameof(ContractType), TransactionType.Append)]
        public string ContractType { get; set; }

        [ImportParameter(nameof(ContractDescription), TransactionType.Append)]
        public string ContractDescription { get; set; }

        [ImportParameter(nameof(ContractStartDate), TransactionType.Append)]
        public DateTime? ContractStartDate { get; set; }

        [ImportParameter(nameof(ContractEndDate), TransactionType.Append)]
        public DateTime? ContractEndDate { get; set; }

        [ImportParameter(nameof(PartsWarrantyStartDate), TransactionType.Append)]
        public DateTime? PartsWarrantyStartDate { get; set; }

        [ImportParameter(nameof(PartsWarrantyEndDate), TransactionType.Append)]
        public DateTime? PartsWarrantyEndDate { get; set; }

        [ImportParameter(nameof(LaborWarrantyStartDate), TransactionType.Append)]
        public DateTime? LaborWarrantyStartDate { get; set; }

        [ImportParameter(nameof(LaborWarrantyEndDate), TransactionType.Append)]
        public DateTime? LaborWarrantyEndDate { get; set; }

        [ImportParameter(nameof(Importance), TransactionType.Append)]
        public int Importance { get; set; }

        [ImportParameter(nameof(Status), TransactionType.Append)]
        public string Status { get; set; }

        [ImportParameter(nameof(ExpectedResponseDateTime), TransactionType.Append)]
        public DateTime? ExpectedResponseDateTime { get; set; }

        [ImportParameter(nameof(ActualResponseDateTime), TransactionType.Append)]
        public DateTime? ActualResponseDateTime { get; set; }

        [ImportParameter(nameof(RequestedStartDatetime), TransactionType.Append)]
        public DateTime? RequestedStartDatetime { get; set; }

        [ImportParameter(nameof(RequestedEndDatetime), TransactionType.Append)]
        public DateTime? RequestedEndDatetime { get; set; }

        [ImportParameter(nameof(ConfirmedStartDatetime), TransactionType.Append)]
        public DateTime? ConfirmedStartDatetime { get; set; }

        [ImportParameter(nameof(ConfirmedEndDatetime), TransactionType.Append)]
        public DateTime? ConfirmedEndDatetime { get; set; }

        [ImportParameter(nameof(ActualStartDatetime), TransactionType.Append)]
        public DateTime? ActualStartDatetime { get; set; }

        [ImportParameter(nameof(ActualEndDatetime), TransactionType.Append)]
        public DateTime? ActualEndDatetime { get; set; }

        [ImportParameter(nameof(LocationDescription), TransactionType.Append)]
        public string LocationDescription { get; set; }

        [ImportParameter(nameof(Duration), TransactionType.Append)]
        public string Duration { get; set; }

        [ImportParameter(nameof(DurationInSeconds), TransactionType.Append)]
        public string DurationInSeconds { get; set; }

        [ImportParameter(nameof(Subject), TransactionType.Append)]
        public string Subject { get; set; }

        [ImportParameter(nameof(Body), TransactionType.Append)]
        public string Body { get; set; }

        [ImportParameter(nameof(InfiniteTask), TransactionType.Append)]
        public bool InfiniteTask { get; set; }

        [ImportParameter(nameof(TaskOpenAsOftime), TransactionType.Append)]
        public DateTime? TaskOpenAsOftime { get; set; }

        [ImportParameter(nameof(TaskOpenTilltime), TransactionType.Append)]
        public DateTime? TaskOpenTilltime { get; set; }

        [ImportParameter(nameof(RequiredTotalDuration), TransactionType.Append)]
        public string RequiredTotalDuration { get; set; }

        [ImportParameter(nameof(RequiredNoResources), TransactionType.Append)]
        public string RequiredNoResources { get; set; }

        [ImportParameter(nameof(AppointmentEarliestAllowedtime), TransactionType.Append)]
        public DateTime? AppointmentEarliestAllowedtime { get; set; }

        [ImportParameter(nameof(AppointmentLatestAllowedtime), TransactionType.Append)]
        public DateTime? AppointmentLatestAllowedtime { get; set; }

        [ImportParameter(nameof(FreeText1), TransactionType.Append)]
        public string FreeText1 { get; set; }

        [ImportParameter(nameof(FreeText2), TransactionType.Append)]
        public string FreeText2 { get; set; }

        [ImportParameter(nameof(FreeText3), TransactionType.Append)]
        public string FreeText3 { get; set; }

        [ImportParameter(nameof(FreeText4), TransactionType.Append)]
        public string FreeText4 { get; set; }

        [ImportParameter(nameof(FreeText5), TransactionType.Append)]
        public string FreeText5 { get; set; }

        [ImportParameter(nameof(FreeText6), TransactionType.Append)]
        public string FreeText6 { get; set; }

        [ImportParameter(nameof(FreeText7), TransactionType.Append)]
        public string FreeText7 { get; set; }

        [ImportParameter(nameof(FreeText8), TransactionType.Append)]
        public string FreeText8 { get; set; }

        [ImportParameter(nameof(FreeText9), TransactionType.Append)]
        public string FreeText9 { get; set; }

        [ImportParameter(nameof(FreeText10), TransactionType.Append)]
        public string FreeText10 { get; set; }

        [ImportParameter(nameof(FreeText11), TransactionType.Append)]
        public string FreeText11 { get; set; }

        [ImportParameter(nameof(FreeText12), TransactionType.Append)]
        public string FreeText12 { get; set; }

        [ImportParameter(nameof(FreeText13), TransactionType.Append)]
        public string FreeText13 { get; set; }

        [ImportParameter(nameof(FreeText14), TransactionType.Append)]
        public string FreeText14 { get; set; }

        [ImportParameter(nameof(FreeText15), TransactionType.Append)]
        public string FreeText15 { get; set; }

        [ImportParameter(nameof(FreeText16), TransactionType.Append)]
        public string FreeText16 { get; set; }

        [ImportParameter(nameof(FreeText17), TransactionType.Append)]
        public string FreeText17 { get; set; }

        [ImportParameter(nameof(FreeText18), TransactionType.Append)]
        public string FreeText18 { get; set; }

        [ImportParameter(nameof(FreeText19), TransactionType.Append)]
        public string FreeText19 { get; set; }

        [ImportParameter(nameof(FreeText20), TransactionType.Append)]
        public string FreeText20 { get; set; }

        [ImportParameter(nameof(FreeDecimal1), TransactionType.Append)]
        public decimal FreeDecimal1 { get; set; }

        [ImportParameter(nameof(FreeDecimal2), TransactionType.Append)]
        public decimal FreeDecimal2 { get; set; }

        [ImportParameter(nameof(FreeDecimal3), TransactionType.Append)]
        public decimal FreeDecimal3 { get; set; }

        [ImportParameter(nameof(FreeDecimal4), TransactionType.Append)]
        public decimal FreeDecimal4 { get; set; }

        [ImportParameter(nameof(FreeDecimal5), TransactionType.Append)]
        public decimal FreeDecimal5 { get; set; }

        [ImportParameter(nameof(FreeDateTime1), TransactionType.Append)]
        public DateTime? FreeDateTime1 { get; set; }

        [ImportParameter(nameof(FreeDateTime2), TransactionType.Append)]
        public DateTime? FreeDateTime2 { get; set; }

        [ImportParameter(nameof(FreeDateTime3), TransactionType.Append)]
        public DateTime? FreeDateTime3 { get; set; }

        [ImportParameter(nameof(FreeDateTime4), TransactionType.Append)]
        public DateTime? FreeDateTime4 { get; set; }

        [ImportParameter(nameof(FreeDateTime5), TransactionType.Append)]
        public DateTime? FreeDateTime5 { get; set; }

        [ImportParameter(nameof(FreeBit1), TransactionType.Append)]
        public bool FreeBit1 { get; set; }

        [ImportParameter(nameof(FreeBit2), TransactionType.Append)]
        public bool FreeBit2 { get; set; }

        [ImportParameter(nameof(FreeBit3), TransactionType.Append)]
        public bool FreeBit3 { get; set; }

        [ImportParameter(nameof(FreeBit4), TransactionType.Append)]
        public bool FreeBit4 { get; set; }

        [ImportParameter(nameof(FreeBit5), TransactionType.Append)]
        public bool FreeBit5 { get; set; }

        [ImportParameter("url1", TransactionType.Append)]
        public string Url1 { get; set; }

        [ImportParameter("urldesc1", TransactionType.Append)]
        public string UrlDescription1 { get; set; }

        [ImportParameter("url2", TransactionType.Append)]
        public string Url2 { get; set; }

        [ImportParameter("urldesc2", TransactionType.Append)]
        public string UrlDescription2 { get; set; }

        [ImportParameter("url3", TransactionType.Append)]
        public string Url3 { get; set; }

        [ImportParameter("urldesc3", TransactionType.Append)]
        public string UrlDescription3 { get; set; }

        [ImportParameter(nameof(CertificateNo), TransactionType.Append)]
        public string CertificateNo { get; set; }

        [ImportParameter(nameof(RequiredTotalDurationInSeconds), TransactionType.Append)]
        public long RequiredTotalDurationInSeconds { get; set; }

        [ImportParameter(nameof(DoNotCountAppointmentResource), TransactionType.Append)]
        public bool DoNotCountAppointmentResource { get; set; }

        [ImportParameter(nameof(IsComplete), TransactionType.Append)]
        public bool IsComplete { get; set; }

        [ImportParameter(nameof(PlanningUOM), TransactionType.Append)]
        public string PlanningUOM { get; set; }

        [ImportParameter(nameof(PlanningUOMConversion), TransactionType.Append)]
        public string PlanningUOMConversion { get; set; }

        [ImportParameter(nameof(PlanningQty), TransactionType.Append)]
        public string PlanningQty { get; set; }

        [ImportParameter(nameof(UseFixPlanningQty), TransactionType.Append)]
        public bool UseFixPlanningQty { get; set; }

        [ImportParameter(nameof(RoundToUOM), TransactionType.Append)]
        public string RoundToUOM { get; set; }

        [ImportParameter(nameof(AppointmentTemplate), TransactionType.Append)]
        public string AppointmentTemplate { get; set; }

        [ImportParameter(nameof(BulkPlanningQty), TransactionType.Append)]
        public string BulkPlanningQty { get; set; }

        [ImportParameter(nameof(StartDatetime), TransactionType.Append)]
        public string StartDatetime { get; set; }

        [ImportParameter(nameof(EndDatetime), TransactionType.Append)]
        public string EndDatetime { get; set; }

        [ImportParameter(nameof(PercentDone), TransactionType.Append)]
        public string PercentDone { get; set; }

        [ImportParameter(nameof(SchedulingMode), TransactionType.Append)]
        public string SchedulingMode { get; set; }

        [ImportParameter(nameof(BaseLineStartDatetime), TransactionType.Append)]
        public string BaseLineStartDatetime { get; set; }

        [ImportParameter(nameof(BaseLineEndDatetime), TransactionType.Append)]
        public string BaseLineEndDatetime { get; set; }

        [ImportParameter(nameof(BaseLinePercentDone), TransactionType.Append)]
        public string BaseLinePercentDone { get; set; }

        [ImportParameter(nameof(DeadLinetime), TransactionType.Append)]
        public string DeadLinetime { get; set; }

        [ImportParameter(nameof(Index), TransactionType.Append)]
        public string Index { get; set; }

        [ImportParameter(nameof(ConstraintType), TransactionType.Append)]
        public string ConstraintType { get; set; }

        [ImportParameter(nameof(ConstraintDatetime), TransactionType.Append)]
        public string ConstraintDatetime { get; set; }

        [ImportParameter(nameof(ParentTaskNo), TransactionType.Append)]
        public string ParentTaskNo { get; set; }

        [ImportParameter(nameof(CalendarCode), TransactionType.Append)]
        public string CalendarCode { get; set; }

        [ImportParameter(nameof(PredecessorTaskNo), TransactionType.Append)]
        public string PredecessorTaskNo { get; set; }

        [ImportParameter(nameof(PredecessorLag), TransactionType.Append)]
        public string PredecessorLag { get; set; }

        [ImportParameter(nameof(ManuallyScheduled), TransactionType.Append)]
        public string ManuallyScheduled { get; set; }

        [ImportParameter(nameof(Note), TransactionType.Append)]
        public string Note { get; set; }

        [ImportParameter(nameof(OverRuleGanttPlanning), TransactionType.Append)]
        public string OverRuleGanttPlanning { get; set; }

        [ImportParameter(nameof(IgnoreCalendars), TransactionType.Append)]
        public string IgnoreCalendars { get; set; }

        [ImportParameter(nameof(ContainerName), TransactionType.Append)]
        public string ContainerName { get; set; }

        [ImportParameter(nameof(ContainerIndex), TransactionType.Append)]
        public string ContainerIndex { get; set; }

        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool CheckAppointments { get; set; }

        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Task>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Task>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(ImportProcedures.Task.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(ImportProcedures.Task.Delete, this.CreateParameters(TransactionType.Delete));

        Task IValidatableImportRequest<Task>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Task>(validationContext);
    }
}