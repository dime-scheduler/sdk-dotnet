using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Task : IImportEntity, IValidatableImportRequest<Task>
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [Description("Identifies the record's originating system.")]
        [ImportParameter(nameof(SourceApp), TransactionType.Append, TransactionType.Delete)]
        [Required]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [Description("Identifies the record's type in the originating system.")]
        [ImportParameter(nameof(SourceType), TransactionType.Append, TransactionType.Delete)]
        [Required]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/JobNo/*'/>
        [Description("Identifies the job.")]
        [ImportParameter(nameof(JobNo), TransactionType.Append, TransactionType.Delete)]
        [MaxLength(50)]
        [Required]
        public string JobNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Work"]/Taskno/*'/>
        [Description("Identifies the task.")]
        [ImportParameter(nameof(TaskNo), TransactionType.Append, TransactionType.Delete)]
        [Required]
        [MaxLength(50)]
        public string TaskNo { get; set; }

        /// <summary>
        /// The type of the task.
        /// </summary>
        [Description("the type of the task.")]
        [ImportParameter(nameof(TaskType), TransactionType.Append)]
        public TaskType TaskType { get; set; }

        /// <summary>
        /// The short description of the task.
        /// </summary>
        [Description("the short description of the task.")]
        [ImportParameter(nameof(ShortDescription), TransactionType.Append)]
        [MaxLength(50)]
        [RequiredIf(TransactionType.Append)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// The description of the task.
        /// </summary>
        [Description("the description of the task.")]
        [ImportParameter(nameof(Description), TransactionType.Append)]
        [MaxLength(50)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the task.
        /// </summary>
        [Description("the name of the task.")]
        [ImportParameter(nameof(Name), TransactionType.Append)]
        [MaxLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the task.
        /// </summary>
        [Description("the type of the task.")]
        [ImportParameter(nameof(Type), TransactionType.Append)]
        [MaxLength(20)]
        public string Type { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Category/*'/>
        [Description("the category.")]
        [ImportParameter(nameof(Category), TransactionType.Append)]
        [MaxLength(100)]
        public string Category { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/TimeMarker/*'/>
        [Description("the time marker.")]
        [ImportParameter(nameof(TimeMarker), TransactionType.Append)]
        [MaxLength(100)]
        public string TimeMarker { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Pin/*'/>
        [Description("the pin indicator.")]
        [ImportParameter(nameof(Pin), TransactionType.Append)]
        [MaxLength(100)]
        public string Pin { get; set; }

        /// <summary>
        /// The service number.
        /// </summary>
        [Description("the service number.")]
        [ImportParameter(nameof(ServiceNo), TransactionType.Append)]
        [MaxLength(50)]
        public string ServiceNo { get; set; }

        /// <summary>
        /// The service group.
        /// </summary>
        [Description("the service group.")]
        [ImportParameter(nameof(ServiceGroup), TransactionType.Append)]
        [MaxLength(20)]
        public string ServiceGroup { get; set; }

        /// <summary>
        /// The service class.
        /// </summary>
        [Description("the service class.")]
        [ImportParameter(nameof(ServiceClass), TransactionType.Append)]
        [MaxLength(20)]
        public string ServiceClass { get; set; }

        /// <summary>
        /// The service serial number.
        /// </summary>
        [Description("the service serial number.")]
        [ImportParameter(nameof(ServiceSerialNo), TransactionType.Append)]
        [MaxLength(50)]
        public string ServiceSerialNo { get; set; }

        /// <summary>
        /// The service name.
        /// </summary>
        [Description("the service name.")]
        [ImportParameter(nameof(ServiceName), TransactionType.Append)]
        [MaxLength(50)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The IRIS fault code.
        /// </summary>
        [Description("the IRIS fault code.")]
        [ImportParameter("IRISFault", TransactionType.Append)]
        [MaxLength(10)]
        public string IrisFault { get; set; }

        /// <summary>
        /// The IRIS symptom code.
        /// </summary>
        [Description("the IRIS symptom code.")]
        [ImportParameter("IRISSymptom", TransactionType.Append)]
        [MaxLength(10)]
        public string IrisSymptom { get; set; }

        /// <summary>
        /// The IRIS area code.
        /// </summary>
        [Description("the IRIS area code.")]
        [ImportParameter("IRISArea", TransactionType.Append)]
        [MaxLength(10)]
        public string IrisArea { get; set; }

        /// <summary>
        /// The IRIS reason code.
        /// </summary>
        [Description("the IRIS reason code.")]
        [ImportParameter("IRISReason", TransactionType.Append)]
        [MaxLength(10)]
        public string IrisReason { get; set; }

        /// <summary>
        /// The IRIS resolution code.
        /// </summary>
        [Description("the IRIS resolution code.")]
        [ImportParameter("IRISResolution", TransactionType.Append)]
        [MaxLength(10)]
        public string IrisResolution { get; set; }

        /// <summary>
        /// The first skill requirement.
        /// </summary>
        [Description("the first skill requirement.")]
        [ImportParameter(nameof(Skill1), TransactionType.Append)]
        [MaxLength(10)]
        public string Skill1 { get; set; }

        /// <summary>
        /// The second skill requirement.
        /// </summary>
        [Description("the second skill requirement.")]
        [ImportParameter(nameof(Skill2), TransactionType.Append)]
        [MaxLength(10)]
        public string Skill2 { get; set; }

        /// <summary>
        /// The third skill requirement.
        /// </summary>
        [Description("the third skill requirement.")]
        [ImportParameter(nameof(Skill3), TransactionType.Append)]
        [MaxLength(10)]
        public string Skill3 { get; set; }

        /// <summary>
        /// The contract number.
        /// </summary>
        [Description("the contract number.")]
        [ImportParameter(nameof(ContractNo), TransactionType.Append)]
        [MaxLength(20)]
        public string ContractNo { get; set; }

        /// <summary>
        /// The contract type.
        /// </summary>
        [Description("the contract type.")]
        [ImportParameter(nameof(ContractType), TransactionType.Append)]
        [MaxLength(30)]
        public string ContractType { get; set; }

        /// <summary>
        /// The contract description.
        /// </summary>
        [Description("the contract description.")]
        [ImportParameter(nameof(ContractDescription), TransactionType.Append)]
        public string ContractDescription { get; set; }

        /// <summary>
        /// The contract start date.
        /// </summary>
        [Description("the contract start date.")]
        [ImportParameter(nameof(ContractStartDate), TransactionType.Append)]
        public DateTime? ContractStartDate { get; set; }

        /// <summary>
        /// The contract end date.
        /// </summary>
        [Description("the contract end date.")]
        [ImportParameter(nameof(ContractEndDate), TransactionType.Append)]
        public DateTime? ContractEndDate { get; set; }

        /// <summary>
        /// The parts warranty start date.
        /// </summary>
        [Description("the parts warranty start date.")]
        [ImportParameter(nameof(PartsWarrantyStartDate), TransactionType.Append)]
        public DateTime? PartsWarrantyStartDate { get; set; }

        /// <summary>
        /// The parts warranty end date.
        /// </summary>
        [Description("the parts warranty end date.")]
        [ImportParameter(nameof(PartsWarrantyEndDate), TransactionType.Append)]
        public DateTime? PartsWarrantyEndDate { get; set; }

        /// <summary>
        /// The labor warranty start date.
        /// </summary>
        [Description("the labor warranty start date.")]
        [ImportParameter(nameof(LaborWarrantyStartDate), TransactionType.Append)]
        public DateTime? LaborWarrantyStartDate { get; set; }

        /// <summary>
        /// The labor warranty end date.
        /// </summary>
        [Description("the labor warranty end date.")]
        [ImportParameter(nameof(LaborWarrantyEndDate), TransactionType.Append)]
        public DateTime? LaborWarrantyEndDate { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Importance/*'/>
        [Description("the importance level.")]
        [ImportParameter(nameof(Importance), TransactionType.Append)]
        public Importance Importance { get; set; }

        /// <summary>
        /// The status of the task.
        /// </summary>
        [Description("the status of the task.")]
        [MaxLength(20)]
        [ImportParameter(nameof(Status), TransactionType.Append)]
        public string Status { get; set; }

        /// <summary>
        /// The expected response date and time.
        /// </summary>
        [Description("the expected response date and time.")]
        [ImportParameter(nameof(ExpectedResponseDateTime), TransactionType.Append)]
        public DateTime? ExpectedResponseDateTime { get; set; }

        /// <summary>
        /// The actual response date and time.
        /// </summary>
        [Description("the actual response date and time.")]
        [ImportParameter(nameof(ActualResponseDateTime), TransactionType.Append)]
        public DateTime? ActualResponseDateTime { get; set; }

        /// <summary>
        /// The requested start date.
        /// </summary>
        [Description("the requested start date.")]
        [ImportParameter(nameof(RequestedStartDate), TransactionType.Append)]
        public DateTime? RequestedStartDate { get; set; }

        /// <summary>
        /// The requested end date.
        /// </summary>
        [Description("the requested end date.")]
        [ImportParameter(nameof(RequestedEndDate), TransactionType.Append)]
        public DateTime? RequestedEndDate { get; set; }

        /// <summary>
        /// The requested start time.
        /// </summary>
        [Description("the requested start time.")]
        [ImportParameter(nameof(RequestedStartTime), TransactionType.Append)]
        public TimeSpan? RequestedStartTime { get; set; }

        /// <summary>
        /// The requested end time.
        /// </summary>
        [Description("the requested end time.")]
        [ImportParameter(nameof(RequestedEndTime), TransactionType.Append)]
        public TimeSpan? RequestedEndTime { get; set; }

        /// <summary>
        /// The confirmed start date.
        /// </summary>
        [Description("the confirmed start date.")]
        [ImportParameter(nameof(ConfirmedStartDate), TransactionType.Append)]
        public DateTime? ConfirmedStartDate { get; set; }

        /// <summary>
        /// The confirmed end date.
        /// </summary>
        [Description("the confirmed end date.")]
        [ImportParameter(nameof(ConfirmedEndDate), TransactionType.Append)]
        public DateTime? ConfirmedEndDate { get; set; }

        /// <summary>
        /// The actual start date.
        /// </summary>
        [Description("the actual start date.")]
        [ImportParameter(nameof(ActualStartDate), TransactionType.Append)]
        public DateTime? ActualStartDate { get; set; }

        /// <summary>
        /// The actual end date.
        /// </summary>
        [Description("the actual end date.")]
        [ImportParameter(nameof(ActualEndDate), TransactionType.Append)]
        public DateTime? ActualEndDate { get; set; }

        /// <summary>
        /// The location description.
        /// </summary>
        [Description("the location description.")]
        [ImportParameter(nameof(LocationDescription), TransactionType.Append)]
        public string LocationDescription { get; set; }

        /// <summary>
        /// The duration of the task.
        /// </summary>
        [Description("the duration of the task.")]
        [ImportParameter(nameof(Duration), TransactionType.Append)]
        public TimeSpan? Duration { get; set; }

        /// <summary>
        /// The duration in seconds.
        /// </summary>
        [Description("the duration in seconds.")]
        [ImportParameter(nameof(DurationInSeconds), TransactionType.Append)]
        public long DurationInSeconds { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Subject/*'/>
        [Description("the subject.")]
        [ImportParameter(nameof(Subject), TransactionType.Append)]
        public string Subject { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Body/*'/>
        [Description("the body content.")]
        [ImportParameter(nameof(Body), TransactionType.Append)]
        public string Body { get; set; }

        /// <summary>
        /// Indicates whether this is an infinite task.
        /// </summary>
        [Description("Indicates whether this is an infinite task.")]
        [ImportParameter(nameof(InfiniteTask), TransactionType.Append)]
        public bool InfiniteTask { get; set; }

        /// <summary>
        /// The date and time when the task opens.
        /// </summary>
        [Description("the date and time when the task opens.")]
        [ImportParameter(nameof(TaskOpenAsOf), TransactionType.Append)]
        public DateTime? TaskOpenAsOf { get; set; }

        /// <summary>
        /// The date and time when the task closes.
        /// </summary>
        [Description("the date and time when the task closes.")]
        [ImportParameter(nameof(TaskOpenTill), TransactionType.Append)]
        public DateTime? TaskOpenTill { get; set; }

        /// <summary>
        /// The required total duration.
        /// </summary>
        [Description("the required total duration.")]
        [ImportParameter(nameof(RequiredTotalDuration), TransactionType.Append)]
        public TimeSpan? RequiredTotalDuration { get; set; }

        /// <summary>
        /// The required number of resources.
        /// </summary>
        [Description("the required number of resources.")]
        [ImportParameter(nameof(RequiredNoResources), TransactionType.Append)]
        public int RequiredNoResources { get; set; }

        /// <summary>
        /// The earliest allowed appointment date and time.
        /// </summary>
        [Description("the earliest allowed appointment date and time.")]
        [ImportParameter(nameof(AppointmentEarliestAllowed), TransactionType.Append)]
        public DateTime? AppointmentEarliestAllowed { get; set; }

        /// <summary>
        /// The latest allowed appointment date and time.
        /// </summary>
        [Description("the latest allowed appointment date and time.")]
        [ImportParameter(nameof(AppointmentLatestAllowed), TransactionType.Append)]
        public DateTime? AppointmentLatestAllowed { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText1), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText2), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText3), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText3 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText4), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText4 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText5), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText5 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText6), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText6 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText7), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText7 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText8), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText8 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText9), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText9 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText10), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText10 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText11), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText11 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText12), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText12 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText13), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText13 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText14), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText14 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText15), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText15 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText16), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText16 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText17), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText17 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText18), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText18 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText19), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText19 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeText/*'/>
        [Description("A text property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeText20), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText20 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDecimal/*'/>
        [Description("A decimal property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeDecimal1), TransactionType.Append)]
        public decimal FreeDecimal1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDecimal/*'/>
        [Description("A decimal property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeDecimal2), TransactionType.Append)]
        public decimal FreeDecimal2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDecimal/*'/>
        [Description("A decimal property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeDecimal3), TransactionType.Append)]
        public decimal FreeDecimal3 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDecimal/*'/>
        [Description("A decimal property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeDecimal4), TransactionType.Append)]
        public decimal FreeDecimal4 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDecimal/*'/>
        [Description("A decimal property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeDecimal5), TransactionType.Append)]
        public decimal FreeDecimal5 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDate/*'/>
        [Description("A date property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeDate1), TransactionType.Append)]
        public DateTime? FreeDate1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDate/*'/>
        [Description("A date property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeDate2), TransactionType.Append)]
        public DateTime? FreeDate2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDate/*'/>
        [Description("A date property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeDate3), TransactionType.Append)]
        public DateTime? FreeDate3 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDate/*'/>
        [Description("A date property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeDate4), TransactionType.Append)]
        public DateTime? FreeDate4 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeDate/*'/>
        [Description("A date property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeDate5), TransactionType.Append)]
        public DateTime? FreeDate5 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeBoolean/*'/>
        [Description("A boolean property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeBit1), TransactionType.Append)]
        public bool FreeBit1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeBoolean/*'/>
        [Description("A boolean property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeBit2), TransactionType.Append)]
        public bool FreeBit2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeBoolean/*'/>
        [Description("A boolean property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeBit3), TransactionType.Append)]
        public bool FreeBit3 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeBoolean/*'/>
        [Description("A boolean property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeBit4), TransactionType.Append)]
        public bool FreeBit4 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="ExtendableEntity"]/FreeBoolean/*'/>
        [Description("A boolean property which can be used at your discretion.")]
        [ImportParameter(nameof(FreeBit5), TransactionType.Append)]
        public bool FreeBit5 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Uri/*'/>
        [Description("the URI.")]
        [ImportParameter("url1", TransactionType.Append)]
        [MaxLength(1000)]
        public string Url1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [Description("the description of the URI.")]
        [ImportParameter("urldesc1", TransactionType.Append)]
        [MaxLength(255)]
        public string UrlDescription1 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Uri/*'/>
        [Description("the URI.")]
        [ImportParameter("url2", TransactionType.Append)]
        [MaxLength(1000)]
        public string Url2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [Description("the description of the URI.")]
        [ImportParameter("urldesc2", TransactionType.Append)]
        [MaxLength(255)]
        public string UrlDescription2 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Uri/*'/>
        [Description("the URI.")]
        [ImportParameter("url3", TransactionType.Append)]
        [MaxLength(1000)]
        public string Url3 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [Description("the description of the URI.")]
        [ImportParameter("urldesc3", TransactionType.Append)]
        [MaxLength(255)]
        public string UrlDescription3 { get; set; }

        /// <summary>
        /// The certificate number.
        /// </summary>
        [ImportParameter(nameof(CertificateNo), TransactionType.Append)]
        public string CertificateNo { get; set; }

        /// <summary>
        /// The required total duration in seconds.
        /// </summary>
        [ImportParameter(nameof(RequiredTotalDurationInSeconds), TransactionType.Append)]
        public long RequiredTotalDurationInSeconds { get; set; }

        /// <summary>
        /// Indicates whether to not count appointment resources.
        /// </summary>
        [ImportParameter(nameof(DoNotCountAppointmentResource), TransactionType.Append)]
        public bool DoNotCountAppointmentResource { get; set; }

        /// <summary>
        /// Indicates whether the task is complete.
        /// </summary>
        [ImportParameter(nameof(IsComplete), TransactionType.Append)]
        public bool IsComplete { get; set; }

        /// <summary>
        /// The planning unit of measure.
        /// </summary>
        [ImportParameter(nameof(PlanningUOM), TransactionType.Append)]
        [MaxLength(20)]
        public string PlanningUOM { get; set; }

        /// <summary>
        /// The planning unit of measure conversion factor.
        /// </summary>
        [ImportParameter(nameof(PlanningUOMConversion), TransactionType.Append)]
        public decimal PlanningUOMConversion { get; set; }

        /// <summary>
        /// The planning quantity.
        /// </summary>
        [ImportParameter(nameof(PlanningQty), TransactionType.Append)]
        public decimal PlanningQty { get; set; }

        /// <summary>
        /// Indicates whether to use fixed planning quantity.
        /// </summary>
        [ImportParameter(nameof(UseFixPlanningQty), TransactionType.Append)]
        public bool UseFixPlanningQty { get; set; }

        /// <summary>
        /// Indicates whether to round to unit of measure.
        /// </summary>
        [ImportParameter(nameof(RoundToUOM), TransactionType.Append)]
        public bool RoundToUOM { get; set; }

        /// <summary>
        /// The appointment template.
        /// </summary>
        [ImportParameter(nameof(AppointmentTemplate), TransactionType.Append)]
        [MaxLength(100)]
        public string AppointmentTemplate { get; set; }

        /// <summary>
        /// The bulk planning quantity.
        /// </summary>
        [ImportParameter(nameof(BulkPlanningQty), TransactionType.Append)]
        public decimal BulkPlanningQty { get; set; }

        /// <summary>
        /// The start date of the task.
        /// </summary>
        [ImportParameter(nameof(StartDate), TransactionType.Append)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of the task.
        /// </summary>
        [ImportParameter(nameof(EndDate), TransactionType.Append)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The percentage of completion.
        /// </summary>
        [ImportParameter(nameof(PercentDone), TransactionType.Append)]
        public int PercentDone { get; set; }

        /// <summary>
        /// The scheduling mode.
        /// </summary>
        [ImportParameter(nameof(SchedulingMode), TransactionType.Append)]
        public SchedulingMode SchedulingMode { get; set; }

        /// <summary>
        /// The baseline start date.
        /// </summary>
        [ImportParameter(nameof(BaseLineStartDate), TransactionType.Append)]
        public DateTime? BaseLineStartDate { get; set; }

        /// <summary>
        /// The baseline end date.
        /// </summary>
        [ImportParameter(nameof(BaseLineEndDate), TransactionType.Append)]
        public DateTime? BaseLineEndDate { get; set; }

        /// <summary>
        /// The baseline percentage of completion.
        /// </summary>
        [ImportParameter(nameof(BaseLinePercentDone), TransactionType.Append)]
        public int BaseLinePercentDone { get; set; }

        /// <summary>
        /// The deadline date and time.
        /// </summary>
        [ImportParameter(nameof(DeadLine), TransactionType.Append)]
        public DateTime? DeadLine { get; set; }

        /// <summary>
        /// The index of the task.
        /// </summary>
        [ImportParameter(nameof(Index), TransactionType.Append)]
        public int Index { get; set; }

        /// <summary>
        /// The constraint type.
        /// </summary>
        [ImportParameter(nameof(ConstraintType), TransactionType.Append)]
        public int ConstraintType { get; set; }

        /// <summary>
        /// The constraint date.
        /// </summary>
        [ImportParameter(nameof(ConstraintDate), TransactionType.Append)]
        public DateTime? ConstraintDate { get; set; }

        /// <summary>
        /// The parent task number.
        /// </summary>
        [ImportParameter(nameof(ParentTaskNo), TransactionType.Append)]
        [MaxLength(50)]
        public string ParentTaskNo { get; set; }

        /// <summary>
        /// The calendar code.
        /// </summary>
        [ImportParameter(nameof(CalendarCode), TransactionType.Append)]
        [MaxLength(255)]
        public string CalendarCode { get; set; }

        /// <summary>
        /// The predecessor task number.
        /// </summary>
        [ImportParameter(nameof(PredecessorTaskNo), TransactionType.Append)]
        [MaxLength(50)]
        public string PredecessorTaskNo { get; set; }

        /// <summary>
        /// The predecessor lag time.
        /// </summary>
        [ImportParameter(nameof(PredecessorLag), TransactionType.Append)]
        public int PredecessorLag { get; set; }

        /// <summary>
        /// Indicates whether the task is manually scheduled.
        /// </summary>
        [ImportParameter(nameof(ManuallyScheduled), TransactionType.Append)]
        public bool ManuallyScheduled { get; set; }

        /// <summary>
        /// The note for the task.
        /// </summary>
        [ImportParameter(nameof(Note), TransactionType.Append)]
        public string Note { get; set; }

        /// <summary>
        /// Indicates whether to override Gantt planning.
        /// </summary>
        [ImportParameter(nameof(OverRuleGanttPlanning), TransactionType.Append)]
        public bool OverRuleGanttPlanning { get; set; }

        /// <summary>
        /// Indicates whether to ignore calendars.
        /// </summary>
        [ImportParameter(nameof(IgnoreCalendars), TransactionType.Append)]
        public bool IgnoreCalendars { get; set; }

        /// <summary>
        /// The container name.
        /// </summary>
        [ImportParameter(nameof(ContainerName), TransactionType.Append)]
        [MaxLength(255)]
        public string ContainerName { get; set; }

        /// <summary>
        /// The container index.
        /// </summary>
        [ImportParameter(nameof(ContainerIndex), TransactionType.Append)]
        public int ContainerIndex { get; set; }

        /// <summary>
        /// Indicates whether to check appointments when deleting.
        /// </summary>
        [ImportParameter(nameof(CheckAppointments), TransactionType.Delete)]
        public bool CheckAppointments { get; set; } = true;

        /// <include file='docs.xml' path='docs/members[@name="Common"]/SentFromBackOffice/*'/>
        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool SentFromBackOffice { get; set; } = true;

        /// <summary>
        /// Indicates whether to create a job.
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