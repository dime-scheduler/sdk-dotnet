using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Task : IImportEntity, IValidatableImportRequest<Task>
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp), TransactionType.Append, TransactionType.Delete)]
        [Required]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType), TransactionType.Append, TransactionType.Delete)]
        [Required]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/JobNo/*'/>
        [ImportParameter(nameof(JobNo), TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        [Required]
        public string JobNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/Taskno/*'/>
        [ImportParameter(nameof(TaskNo), TransactionType.Append, TransactionType.Delete)]
        [Required]
        [MaxLength(50)]
        public string TaskNo { get; set; }

        /// <summary>
        /// Gets or sets the type of the task.
        /// </summary>
        [ImportParameter(nameof(TaskType), TransactionType.Append)]
        public TaskType TaskType { get; set; }

        /// <summary>
        /// Gets or sets the short description of the task.
        /// </summary>
        [ImportParameter(nameof(ShortDescription), TransactionType.Append)]
        [MaxLength(50)]
        [RequiredIf(TransactionType.Append)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the description of the task.
        /// </summary>
        [ImportParameter(nameof(Description), TransactionType.Append)]
        [MaxLength(50)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the task.
        /// </summary>
        [ImportParameter(nameof(Name), TransactionType.Append)]
        [MaxLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the task.
        /// </summary>
        [ImportParameter(nameof(Type), TransactionType.Append)]
        [MaxLength(20)]
        public string Type { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Category/*'/>
        [ImportParameter(nameof(Category), TransactionType.Append)]
        [MaxLength(100)]
        public string Category { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/TimeMarker/*'/>
        [ImportParameter(nameof(TimeMarker), TransactionType.Append)]
        [MaxLength(100)]
        public string TimeMarker { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Pin/*'/>
        [ImportParameter(nameof(Pin), TransactionType.Append)]
        [MaxLength(100)]
        public string Pin { get; set; }

        /// <summary>
        /// Gets or sets the service number.
        /// </summary>
        [ImportParameter(nameof(ServiceNo), TransactionType.Append)]
        [MaxLength(50)]
        public string ServiceNo { get; set; }

        /// <summary>
        /// Gets or sets the service group.
        /// </summary>
        [ImportParameter(nameof(ServiceGroup), TransactionType.Append)]
        [MaxLength(20)]
        public string ServiceGroup { get; set; }

        /// <summary>
        /// Gets or sets the service class.
        /// </summary>
        [ImportParameter(nameof(ServiceClass), TransactionType.Append)]
        [MaxLength(20)]
        public string ServiceClass { get; set; }

        /// <summary>
        /// Gets or sets the service serial number.
        /// </summary>
        [ImportParameter(nameof(ServiceSerialNo), TransactionType.Append)]
        [MaxLength(50)]
        public string ServiceSerialNo { get; set; }

        /// <summary>
        /// Gets or sets the service name.
        /// </summary>
        [ImportParameter(nameof(ServiceName), TransactionType.Append)]
        [MaxLength(50)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets the IRIS fault code.
        /// </summary>
        [ImportParameter("IRISFault", TransactionType.Append)]
        [MaxLength(10)]
        public string IrisFault { get; set; }

        /// <summary>
        /// Gets or sets the IRIS symptom code.
        /// </summary>
        [ImportParameter("IRISSymptom", TransactionType.Append)]
        [MaxLength(10)]
        public string IrisSymptom { get; set; }

        /// <summary>
        /// Gets or sets the IRIS area code.
        /// </summary>
        [ImportParameter("IRISArea", TransactionType.Append)]
        [MaxLength(10)]
        public string IrisArea { get; set; }

        /// <summary>
        /// Gets or sets the IRIS reason code.
        /// </summary>
        [ImportParameter("IRISReason", TransactionType.Append)]
        [MaxLength(10)]
        public string IrisReason { get; set; }

        /// <summary>
        /// Gets or sets the IRIS resolution code.
        /// </summary>
        [ImportParameter("IRISResolution", TransactionType.Append)]
        [MaxLength(10)]
        public string IrisResolution { get; set; }

        /// <summary>
        /// Gets or sets the first skill requirement.
        /// </summary>
        [ImportParameter(nameof(Skill1), TransactionType.Append)]
        [MaxLength(10)]
        public string Skill1 { get; set; }

        /// <summary>
        /// Gets or sets the second skill requirement.
        /// </summary>
        [ImportParameter(nameof(Skill2), TransactionType.Append)]
        [MaxLength(10)]
        public string Skill2 { get; set; }

        /// <summary>
        /// Gets or sets the third skill requirement.
        /// </summary>
        [ImportParameter(nameof(Skill3), TransactionType.Append)]
        [MaxLength(10)]
        public string Skill3 { get; set; }

        /// <summary>
        /// Gets or sets the contract number.
        /// </summary>
        [ImportParameter(nameof(ContractNo), TransactionType.Append)]
        [MaxLength(20)]
        public string ContractNo { get; set; }

        /// <summary>
        /// Gets or sets the contract type.
        /// </summary>
        [ImportParameter(nameof(ContractType), TransactionType.Append)]
        [MaxLength(30)]
        public string ContractType { get; set; }

        /// <summary>
        /// Gets or sets the contract description.
        /// </summary>
        [ImportParameter(nameof(ContractDescription), TransactionType.Append)]
        public string ContractDescription { get; set; }

        /// <summary>
        /// Gets or sets the contract start date.
        /// </summary>
        [ImportParameter(nameof(ContractStartDate), TransactionType.Append)]
        public DateTime? ContractStartDate { get; set; }

        /// <summary>
        /// Gets or sets the contract end date.
        /// </summary>
        [ImportParameter(nameof(ContractEndDate), TransactionType.Append)]
        public DateTime? ContractEndDate { get; set; }

        /// <summary>
        /// Gets or sets the parts warranty start date.
        /// </summary>
        [ImportParameter(nameof(PartsWarrantyStartDate), TransactionType.Append)]
        public DateTime? PartsWarrantyStartDate { get; set; }

        /// <summary>
        /// Gets or sets the parts warranty end date.
        /// </summary>
        [ImportParameter(nameof(PartsWarrantyEndDate), TransactionType.Append)]
        public DateTime? PartsWarrantyEndDate { get; set; }

        /// <summary>
        /// Gets or sets the labor warranty start date.
        /// </summary>
        [ImportParameter(nameof(LaborWarrantyStartDate), TransactionType.Append)]
        public DateTime? LaborWarrantyStartDate { get; set; }

        /// <summary>
        /// Gets or sets the labor warranty end date.
        /// </summary>
        [ImportParameter(nameof(LaborWarrantyEndDate), TransactionType.Append)]
        public DateTime? LaborWarrantyEndDate { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Importance/*'/>
        [ImportParameter(nameof(Importance), TransactionType.Append)]
        public Importance Importance { get; set; }

        /// <summary>
        /// Gets or sets the status of the task.
        /// </summary>
        [MaxLength(20)]
        [ImportParameter(nameof(Status), TransactionType.Append)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the expected response date and time.
        /// </summary>
        [ImportParameter(nameof(ExpectedResponseDateTime), TransactionType.Append)]
        public DateTime? ExpectedResponseDateTime { get; set; }

        /// <summary>
        /// Gets or sets the actual response date and time.
        /// </summary>
        [ImportParameter(nameof(ActualResponseDateTime), TransactionType.Append)]
        public DateTime? ActualResponseDateTime { get; set; }

        /// <summary>
        /// Gets or sets the requested start date.
        /// </summary>
        [ImportParameter(nameof(RequestedStartDate), TransactionType.Append)]
        public DateTime? RequestedStartDate { get; set; }

        /// <summary>
        /// Gets or sets the requested end date.
        /// </summary>
        [ImportParameter(nameof(RequestedEndDate), TransactionType.Append)]
        public DateTime? RequestedEndDate { get; set; }

        /// <summary>
        /// Gets or sets the requested start time.
        /// </summary>
        [ImportParameter(nameof(RequestedStartTime), TransactionType.Append)]
        public TimeSpan? RequestedStartTime { get; set; }

        /// <summary>
        /// Gets or sets the requested end time.
        /// </summary>
        [ImportParameter(nameof(RequestedEndTime), TransactionType.Append)]
        public TimeSpan? RequestedEndTime { get; set; }

        /// <summary>
        /// Gets or sets the confirmed start date.
        /// </summary>
        [ImportParameter(nameof(ConfirmedStartDate), TransactionType.Append)]
        public DateTime? ConfirmedStartDate { get; set; }

        /// <summary>
        /// Gets or sets the confirmed end date.
        /// </summary>
        [ImportParameter(nameof(ConfirmedEndDate), TransactionType.Append)]
        public DateTime? ConfirmedEndDate { get; set; }

        /// <summary>
        /// Gets or sets the actual start date.
        /// </summary>
        [ImportParameter(nameof(ActualStartDate), TransactionType.Append)]
        public DateTime? ActualStartDate { get; set; }

        /// <summary>
        /// Gets or sets the actual end date.
        /// </summary>
        [ImportParameter(nameof(ActualEndDate), TransactionType.Append)]
        public DateTime? ActualEndDate { get; set; }

        /// <summary>
        /// Gets or sets the location description.
        /// </summary>
        [ImportParameter(nameof(LocationDescription), TransactionType.Append)]
        public string LocationDescription { get; set; }

        /// <summary>
        /// Gets or sets the duration of the task.
        /// </summary>
        [ImportParameter(nameof(Duration), TransactionType.Append)]
        public TimeSpan? Duration { get; set; }

        /// <summary>
        /// Gets or sets the duration in seconds.
        /// </summary>
        [ImportParameter(nameof(DurationInSeconds), TransactionType.Append)]
        public long DurationInSeconds { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Subject/*'/>
        [ImportParameter(nameof(Subject), TransactionType.Append)]
        public string Subject { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Body/*'/>
        [ImportParameter(nameof(Body), TransactionType.Append)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is an infinite task.
        /// </summary>
        [ImportParameter(nameof(InfiniteTask), TransactionType.Append)]
        public bool InfiniteTask { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the task opens.
        /// </summary>
        [ImportParameter(nameof(TaskOpenAsOf), TransactionType.Append)]
        public DateTime? TaskOpenAsOf { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the task closes.
        /// </summary>
        [ImportParameter(nameof(TaskOpenTill), TransactionType.Append)]
        public DateTime? TaskOpenTill { get; set; }

        /// <summary>
        /// Gets or sets the required total duration.
        /// </summary>
        [ImportParameter(nameof(RequiredTotalDuration), TransactionType.Append)]
        public TimeSpan? RequiredTotalDuration { get; set; }

        /// <summary>
        /// Gets or sets the required number of resources.
        /// </summary>
        [ImportParameter(nameof(RequiredNoResources), TransactionType.Append)]
        public int RequiredNoResources { get; set; }

        /// <summary>
        /// Gets or sets the earliest allowed appointment date and time.
        /// </summary>
        [ImportParameter(nameof(AppointmentEarliestAllowed), TransactionType.Append)]
        public DateTime? AppointmentEarliestAllowed { get; set; }

        /// <summary>
        /// Gets or sets the latest allowed appointment date and time.
        /// </summary>
        [ImportParameter(nameof(AppointmentLatestAllowed), TransactionType.Append)]
        public DateTime? AppointmentLatestAllowed { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText1), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText2), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText3), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText3 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText4), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText4 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText5), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText5 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText6), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText6 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText7), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText7 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText8), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText8 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText9), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText9 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText10), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText10 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText11), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText11 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText12), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText12 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText13), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText13 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText14), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText14 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText15), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText15 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText16), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText16 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText17), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText17 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText18), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText18 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText19), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText19 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [ImportParameter(nameof(FreeText20), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText20 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDecimal/*'/>
        [ImportParameter(nameof(FreeDecimal1), TransactionType.Append)]
        public decimal FreeDecimal1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDecimal/*'/>
        [ImportParameter(nameof(FreeDecimal2), TransactionType.Append)]
        public decimal FreeDecimal2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDecimal/*'/>
        [ImportParameter(nameof(FreeDecimal3), TransactionType.Append)]
        public decimal FreeDecimal3 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDecimal/*'/>
        [ImportParameter(nameof(FreeDecimal4), TransactionType.Append)]
        public decimal FreeDecimal4 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDecimal/*'/>
        [ImportParameter(nameof(FreeDecimal5), TransactionType.Append)]
        public decimal FreeDecimal5 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDate/*'/>
        [ImportParameter(nameof(FreeDate1), TransactionType.Append)]
        public DateTime? FreeDate1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDate/*'/>
        [ImportParameter(nameof(FreeDate2), TransactionType.Append)]
        public DateTime? FreeDate2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDate/*'/>
        [ImportParameter(nameof(FreeDate3), TransactionType.Append)]
        public DateTime? FreeDate3 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDate/*'/>
        [ImportParameter(nameof(FreeDate4), TransactionType.Append)]
        public DateTime? FreeDate4 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDate/*'/>
        [ImportParameter(nameof(FreeDate5), TransactionType.Append)]
        public DateTime? FreeDate5 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeBoolean/*'/>
        [ImportParameter(nameof(FreeBit1), TransactionType.Append)]
        public bool FreeBit1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeBoolean/*'/>
        [ImportParameter(nameof(FreeBit2), TransactionType.Append)]
        public bool FreeBit2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeBoolean/*'/>
        [ImportParameter(nameof(FreeBit3), TransactionType.Append)]
        public bool FreeBit3 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeBoolean/*'/>
        [ImportParameter(nameof(FreeBit4), TransactionType.Append)]
        public bool FreeBit4 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeBoolean/*'/>
        [ImportParameter(nameof(FreeBit5), TransactionType.Append)]
        public bool FreeBit5 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Uri/*'/>
        [ImportParameter("url1", TransactionType.Append)]
        [MaxLength(1000)]
        public string Url1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [ImportParameter("urldesc1", TransactionType.Append)]
        [MaxLength(255)]
        public string UrlDescription1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Uri/*'/>
        [ImportParameter("url2", TransactionType.Append)]
        [MaxLength(1000)]
        public string Url2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [ImportParameter("urldesc2", TransactionType.Append)]
        [MaxLength(255)]
        public string UrlDescription2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Uri/*'/>
        [ImportParameter("url3", TransactionType.Append)]
        [MaxLength(1000)]
        public string Url3 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [ImportParameter("urldesc3", TransactionType.Append)]
        [MaxLength(255)]
        public string UrlDescription3 { get; set; }

        /// <summary>
        /// Gets or sets the certificate number.
        /// </summary>
        [ImportParameter(nameof(CertificateNo), TransactionType.Append)]
        public string CertificateNo { get; set; }

        /// <summary>
        /// Gets or sets the required total duration in seconds.
        /// </summary>
        [ImportParameter(nameof(RequiredTotalDurationInSeconds), TransactionType.Append)]
        public long RequiredTotalDurationInSeconds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to not count appointment resources.
        /// </summary>
        [ImportParameter(nameof(DoNotCountAppointmentResource), TransactionType.Append)]
        public bool DoNotCountAppointmentResource { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the task is complete.
        /// </summary>
        [ImportParameter(nameof(IsComplete), TransactionType.Append)]
        public bool IsComplete { get; set; }

        /// <summary>
        /// Gets or sets the planning unit of measure.
        /// </summary>
        [ImportParameter(nameof(PlanningUOM), TransactionType.Append)]
        [MaxLength(20)]
        public string PlanningUOM { get; set; }

        /// <summary>
        /// Gets or sets the planning unit of measure conversion factor.
        /// </summary>
        [ImportParameter(nameof(PlanningUOMConversion), TransactionType.Append)]
        public decimal PlanningUOMConversion { get; set; }

        /// <summary>
        /// Gets or sets the planning quantity.
        /// </summary>
        [ImportParameter(nameof(PlanningQty), TransactionType.Append)]
        public decimal PlanningQty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use fixed planning quantity.
        /// </summary>
        [ImportParameter(nameof(UseFixPlanningQty), TransactionType.Append)]
        public bool UseFixPlanningQty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to round to unit of measure.
        /// </summary>
        [ImportParameter(nameof(RoundToUOM), TransactionType.Append)]
        public bool RoundToUOM { get; set; }

        /// <summary>
        /// Gets or sets the appointment template.
        /// </summary>
        [ImportParameter(nameof(AppointmentTemplate), TransactionType.Append)]
        [MaxLength(100)]
        public string AppointmentTemplate { get; set; }

        /// <summary>
        /// Gets or sets the bulk planning quantity.
        /// </summary>
        [ImportParameter(nameof(BulkPlanningQty), TransactionType.Append)]
        public decimal BulkPlanningQty { get; set; }

        /// <summary>
        /// Gets or sets the start date of the task.
        /// </summary>
        [ImportParameter(nameof(StartDate), TransactionType.Append)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of the task.
        /// </summary>
        [ImportParameter(nameof(EndDate), TransactionType.Append)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the percentage of completion.
        /// </summary>
        [ImportParameter(nameof(PercentDone), TransactionType.Append)]
        public int PercentDone { get; set; }

        /// <summary>
        /// Gets or sets the scheduling mode.
        /// </summary>
        [ImportParameter(nameof(SchedulingMode), TransactionType.Append)]
        public SchedulingMode SchedulingMode { get; set; }

        /// <summary>
        /// Gets or sets the baseline start date.
        /// </summary>
        [ImportParameter(nameof(BaseLineStartDate), TransactionType.Append)]
        public DateTime? BaseLineStartDate { get; set; }

        /// <summary>
        /// Gets or sets the baseline end date.
        /// </summary>
        [ImportParameter(nameof(BaseLineEndDate), TransactionType.Append)]
        public DateTime? BaseLineEndDate { get; set; }

        /// <summary>
        /// Gets or sets the baseline percentage of completion.
        /// </summary>
        [ImportParameter(nameof(BaseLinePercentDone), TransactionType.Append)]
        public int BaseLinePercentDone { get; set; }

        /// <summary>
        /// Gets or sets the deadline date and time.
        /// </summary>
        [ImportParameter(nameof(DeadLine), TransactionType.Append)]
        public DateTime? DeadLine { get; set; }

        /// <summary>
        /// Gets or sets the index of the task.
        /// </summary>
        [ImportParameter(nameof(Index), TransactionType.Append)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets the constraint type.
        /// </summary>
        [ImportParameter(nameof(ConstraintType), TransactionType.Append)]
        public int ConstraintType { get; set; }

        /// <summary>
        /// Gets or sets the constraint date.
        /// </summary>
        [ImportParameter(nameof(ConstraintDate), TransactionType.Append)]
        public DateTime? ConstraintDate { get; set; }

        /// <summary>
        /// Gets or sets the parent task number.
        /// </summary>
        [ImportParameter(nameof(ParentTaskNo), TransactionType.Append)]
        [MaxLength(50)]
        public string ParentTaskNo { get; set; }

        /// <summary>
        /// Gets or sets the calendar code.
        /// </summary>
        [ImportParameter(nameof(CalendarCode), TransactionType.Append)]
        [MaxLength(255)]
        public string CalendarCode { get; set; }

        /// <summary>
        /// Gets or sets the predecessor task number.
        /// </summary>
        [ImportParameter(nameof(PredecessorTaskNo), TransactionType.Append)]
        [MaxLength(50)]
        public string PredecessorTaskNo { get; set; }

        /// <summary>
        /// Gets or sets the predecessor lag time.
        /// </summary>
        [ImportParameter(nameof(PredecessorLag), TransactionType.Append)]
        public int PredecessorLag { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the task is manually scheduled.
        /// </summary>
        [ImportParameter(nameof(ManuallyScheduled), TransactionType.Append)]
        public bool ManuallyScheduled { get; set; }

        /// <summary>
        /// Gets or sets the note for the task.
        /// </summary>
        [ImportParameter(nameof(Note), TransactionType.Append)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to override Gantt planning.
        /// </summary>
        [ImportParameter(nameof(OverRuleGanttPlanning), TransactionType.Append)]
        public bool OverRuleGanttPlanning { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to ignore calendars.
        /// </summary>
        [ImportParameter(nameof(IgnoreCalendars), TransactionType.Append)]
        public bool IgnoreCalendars { get; set; }

        /// <summary>
        /// Gets or sets the container name.
        /// </summary>
        [ImportParameter(nameof(ContainerName), TransactionType.Append)]
        [MaxLength(255)]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or sets the container index.
        /// </summary>
        [ImportParameter(nameof(ContainerIndex), TransactionType.Append)]
        public int ContainerIndex { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to check appointments when deleting.
        /// </summary>
        [ImportParameter(nameof(CheckAppointments), TransactionType.Delete)]
        public bool CheckAppointments { get; set; } = true;

        /// <include file='docs.xml' path='docs/members[@name="Common"]/SentFromBackOffice/*'/>
        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool SentFromBackOffice { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to create a job.
        /// </summary>
        public bool CreateJob { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Task>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Task>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Task.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Task.Delete, this.CreateParameters(TransactionType.Delete));

        Task IValidatableImportRequest<Task>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Task>(validationContext);
    }
}