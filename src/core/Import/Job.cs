using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    /// <summary>
    /// A job is a meta entity that holds information such as customer, contact, addresses, and more.
    /// </summary>
    public class Job : IImportRequestable, IValidatableImportRequest<Job>
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
        [Required]
        [MaxLength(50)]
        public string JobNo { get; set; }

        [ImportParameter(nameof(ShortDescription), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string ShortDescription { get; set; }

        [ImportParameter(nameof(Description), TransactionType.Append)]
        public string Description { get; set; }

        [ImportParameter(nameof(Type), TransactionType.Append)]
        [MaxLength(50)]
        public string Type { get; set; }

        [ImportParameter(nameof(Name), TransactionType.Append)]
        [MaxLength(255)]
        public string Name { get; set; }

        [ImportParameter(nameof(Category), TransactionType.Append)]
        [MaxLength(100)]
        public string Category { get; set; }

        [ImportParameter(nameof(TimeMarker), TransactionType.Append)]
        [MaxLength(100)]
        public string TimeMarker { get; set; }

        [ImportParameter(nameof(Pin), TransactionType.Append)]
        [MaxLength(100)]
        public string Pin { get; set; }

        [ImportParameter(nameof(CustomerNo), TransactionType.Append)]
        [MaxLength(20)]
        public string CustomerNo { get; set; }

        [ImportParameter(nameof(CustomerName), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [ImportParameter(nameof(CustomerAddress), TransactionType.Append)]
        public string CustomerAddress { get; set; }

        [ImportParameter(nameof(CustomerAddressGeoLong), TransactionType.Append)]        
        public decimal CustomerAddressGeoLong { get; set; }

        [ImportParameter(nameof(CustomerAddressGeoLat), TransactionType.Append)]        
        public decimal CustomerAddressGeoLat { get; set; }

        [ImportParameter(nameof(CustomerPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerPhone { get; set; }

        [ImportParameter(nameof(CustomerEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerEmail { get; set; }

        [ImportParameter(nameof(ContactNo), TransactionType.Append)]
        [MaxLength(20)]
        public string ContactNo { get; set; }

        [ImportParameter(nameof(ContactName), TransactionType.Append)]
        [MaxLength(50)]
        public string ContactName { get; set; }

        [ImportParameter(nameof(ContactAddress), TransactionType.Append)]
        public string ContactAddress { get; set; }

        [ImportParameter(nameof(ContactAddressGeoLong), TransactionType.Append)]        
        public decimal ContactAddressGeoLong { get; set; }

        [ImportParameter(nameof(ContactAddressGeoLat), TransactionType.Append)]        
        public decimal ContactAddressGeoLat { get; set; }

        [ImportParameter(nameof(ContactPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string ContactPhone { get; set; }

        [ImportParameter(nameof(ContactEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string ContactEmail { get; set; }

        [ImportParameter(nameof(SiteNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteNo { get; set; }

        [ImportParameter(nameof(SiteName), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteName { get; set; }

        [ImportParameter(nameof(SiteAddress), TransactionType.Append)]
        public string SiteAddress { get; set; }

        [ImportParameter(nameof(SiteAddressGeoLong), TransactionType.Append)]        
        public decimal SiteAddressGeoLong { get; set; }

        [ImportParameter(nameof(SiteAddressGeoLat), TransactionType.Append)]        
        public decimal SiteAddressGeoLat { get; set; }

        [ImportParameter(nameof(SitePhone), TransactionType.Append)]
        [MaxLength(50)]
        public string SitePhone { get; set; }

        [ImportParameter(nameof(SiteEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteEmail { get; set; }

        [ImportParameter(nameof(SiteRegion), TransactionType.Append)]
        [MaxLength(10)]
        public string SiteRegion { get; set; }

        [ImportParameter(nameof(SiteStreet), TransactionType.Append)]
        [MaxLength(255)]
        public string SiteStreet { get; set; }

        [ImportParameter(nameof(SiteStreetNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteStreetNo { get; set; }

        [ImportParameter(nameof(SitePostcode), TransactionType.Append)]
        [MaxLength(20)]
        public string SitePostcode { get; set; }

        [ImportParameter(nameof(SiteCity), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteCity { get; set; }

        [ImportParameter(nameof(SiteCounty), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteCounty { get; set; }

        [ImportParameter(nameof(SiteState), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteState { get; set; }

        [ImportParameter(nameof(SiteCountry), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteCountry { get; set; }

        [ImportParameter(nameof(SiteFromNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteFromNo { get; set; }

        [ImportParameter(nameof(SiteFromName), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromName { get; set; }

        [ImportParameter(nameof(SiteFromAddress), TransactionType.Append)]
        public string SiteFromAddress { get; set; }

        [ImportParameter(nameof(SiteFromAddressGeoLong), TransactionType.Append)]        
        public decimal SiteFromAddressGeoLong { get; set; }

        [ImportParameter(nameof(SiteFromAddressGeoLat), TransactionType.Append)]        
        public decimal SiteFromAddressGeoLat { get; set; }

        [ImportParameter(nameof(SiteFromPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromPhone { get; set; }

        [ImportParameter(nameof(SiteFromEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromEmail { get; set; }

        [ImportParameter(nameof(SiteFromRegion), TransactionType.Append)]
        [MaxLength(10)]
        public string SiteFromRegion { get; set; }

        [ImportParameter(nameof(SiteFromStreet), TransactionType.Append)]
        [MaxLength(255)]
        public string SiteFromStreet { get; set; }

        [ImportParameter(nameof(SiteFromStreetNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteFromStreetNo { get; set; }

        [ImportParameter(nameof(SiteFromPostcode), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteFromPostcode { get; set; }

        [ImportParameter(nameof(SiteFromCity), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromCity { get; set; }

        [ImportParameter(nameof(SiteFromCounty), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromCounty { get; set; }

        [ImportParameter(nameof(SiteFromState), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromState { get; set; }

        [ImportParameter(nameof(SiteFromCountry), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromCountry { get; set; }

        [ImportParameter(nameof(BillNo), TransactionType.Append)]
        [MaxLength(20)]
        public string BillNo { get; set; }

        [ImportParameter(nameof(BillName), TransactionType.Append)]
        [MaxLength(50)]
        public string BillName { get; set; }

        [ImportParameter(nameof(BillAddress), TransactionType.Append)]
        public string BillAddress { get; set; }

        [ImportParameter(nameof(BillAddressGeoLong), TransactionType.Append)]        
        public decimal BillAddressGeoLong { get; set; }

        [ImportParameter(nameof(BillAddressGeoLat), TransactionType.Append)]        
        public decimal BillAddressGeoLat { get; set; }

        [ImportParameter(nameof(BillPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string BillPhone { get; set; }

        [ImportParameter(nameof(BillEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string BillEmail { get; set; }

        [ImportParameter(nameof(BillRegion), TransactionType.Append)]
        [MaxLength(10)]
        public string BillRegion { get; set; }

        [ImportParameter(nameof(Importance), TransactionType.Append)]
        public Importance Importance { get; set; }

        [ImportParameter(nameof(CreationDateTime), TransactionType.Append)]
        public DateTime? CreationDateTime { get; set; }

        [ImportParameter(nameof(CustomerReference), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerReference { get; set; }

        [ImportParameter(nameof(Language), TransactionType.Append)]
        [MaxLength(10)]
        public string Language { get; set; }

        [ImportParameter(nameof(Responsible), TransactionType.Append)]
        [MaxLength(50)]
        public string Responsible { get; set; }

        [ImportParameter(nameof(Creator), TransactionType.Append)]
        [MaxLength(50)]
        public string Creator { get; set; }

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

        [ImportParameter(nameof(EnableManualSelection), TransactionType.Append)]
        public bool EnableManualSelection { get; set; }

        [ImportParameter(nameof(AvailableInGantt), TransactionType.Append)]
        public bool AvailableInGantt { get; set; }

        [ImportParameter(nameof(StartDate), TransactionType.Append)]
        public DateTime? StartDate { get; set; }

        [ImportParameter(nameof(EndDate), TransactionType.Append)]
        public DateTime? EndDate { get; set; }

        [ImportParameter(nameof(AllowDependencies), TransactionType.Append)]
        public bool AllowDependencies { get; set; } = true;

        [ImportParameter(nameof(Note), TransactionType.Append)]
        public string Note { get; set; }

        [ImportParameter(nameof(OverRuleGanttPlanning), TransactionType.Append)]
        public bool OverRuleGanttPlanning { get; set; }

        [ImportParameter(nameof(CheckAppointments), TransactionType.Delete)]
        public bool CheckAppointments { get; set; }

        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool SentFromBackOffice { get; set; } = true;

        [ImportParameter(nameof(ReadOnly), TransactionType.Append)]
        public bool ReadOnly { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Job>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Job>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Job.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Job.Delete, this.CreateParameters(TransactionType.Delete));

        Job IValidatableImportRequest<Job>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Job>(validationContext);
    }
}