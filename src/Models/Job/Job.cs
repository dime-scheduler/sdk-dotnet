using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// A job is a meta entity that holds information such as customer, contact, addresses, and more.
    /// </summary>
    public class Job : IImportEntity, IValidatableImportRequest<Job>
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

        /// <summary>
        /// Gets or sets the short description of the job.
        /// </summary>
        [ImportParameter(nameof(ShortDescription), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the description of the job.
        /// </summary>
        [ImportParameter(nameof(Description), TransactionType.Append)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the type of the job.
        /// </summary>
        [ImportParameter(nameof(Type), TransactionType.Append)]
        [MaxLength(50)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the job.
        /// </summary>
        [ImportParameter(nameof(Name), TransactionType.Append)]
        [MaxLength(255)]
        public string Name { get; set; }

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
        /// Gets or sets the customer number.
        /// </summary>
        [ImportParameter(nameof(CustomerNo), TransactionType.Append)]
        [MaxLength(20)]
        public string CustomerNo { get; set; }

        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        [ImportParameter(nameof(CustomerName), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the customer address.
        /// </summary>
        [ImportParameter(nameof(CustomerAddress), TransactionType.Append)]
        public string CustomerAddress { get; set; }

        /// <summary>
        /// Gets or sets the customer address longitude coordinate.
        /// </summary>
        [ImportParameter(nameof(CustomerAddressGeoLong), TransactionType.Append)]
        public decimal? CustomerAddressGeoLong { get; set; }

        /// <summary>
        /// Gets or sets the customer address latitude coordinate.
        /// </summary>
        [ImportParameter(nameof(CustomerAddressGeoLat), TransactionType.Append)]
        public decimal? CustomerAddressGeoLat { get; set; }

        /// <summary>
        /// Gets or sets the customer phone number.
        /// </summary>
        [ImportParameter(nameof(CustomerPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerPhone { get; set; }

        /// <summary>
        /// Gets or sets the customer email address.
        /// </summary>
        [ImportParameter(nameof(CustomerEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        [ImportParameter(nameof(ContactNo), TransactionType.Append)]
        [MaxLength(20)]
        public string ContactNo { get; set; }

        /// <summary>
        /// Gets or sets the contact name.
        /// </summary>
        [ImportParameter(nameof(ContactName), TransactionType.Append)]
        [MaxLength(50)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the contact address.
        /// </summary>
        [ImportParameter(nameof(ContactAddress), TransactionType.Append)]
        public string ContactAddress { get; set; }

        /// <summary>
        /// Gets or sets the contact address longitude coordinate.
        /// </summary>
        [ImportParameter(nameof(ContactAddressGeoLong), TransactionType.Append)]
        public decimal? ContactAddressGeoLong { get; set; }

        /// <summary>
        /// Gets or sets the contact address latitude coordinate.
        /// </summary>
        [ImportParameter(nameof(ContactAddressGeoLat), TransactionType.Append)]
        public decimal? ContactAddressGeoLat { get; set; }

        /// <summary>
        /// Gets or sets the contact phone number.
        /// </summary>
        [ImportParameter(nameof(ContactPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Gets or sets the contact email address.
        /// </summary>
        [ImportParameter(nameof(ContactEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the site number.
        /// </summary>
        [ImportParameter(nameof(SiteNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteNo { get; set; }

        /// <summary>
        /// Gets or sets the site name.
        /// </summary>
        [ImportParameter(nameof(SiteName), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteName { get; set; }

        /// <summary>
        /// Gets or sets the site address.
        /// </summary>
        [ImportParameter(nameof(SiteAddress), TransactionType.Append)]
        public string SiteAddress { get; set; }

        /// <summary>
        /// Gets or sets the site address longitude coordinate.
        /// </summary>
        [ImportParameter(nameof(SiteAddressGeoLong), TransactionType.Append)]
        public decimal? SiteAddressGeoLong { get; set; }

        /// <summary>
        /// Gets or sets the site address latitude coordinate.
        /// </summary>
        [ImportParameter(nameof(SiteAddressGeoLat), TransactionType.Append)]
        public decimal? SiteAddressGeoLat { get; set; }

        /// <summary>
        /// Gets or sets the site phone number.
        /// </summary>
        [ImportParameter(nameof(SitePhone), TransactionType.Append)]
        [MaxLength(50)]
        public string SitePhone { get; set; }

        /// <summary>
        /// Gets or sets the site email address.
        /// </summary>
        [ImportParameter(nameof(SiteEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteEmail { get; set; }

        /// <summary>
        /// Gets or sets the site region.
        /// </summary>
        [ImportParameter(nameof(SiteRegion), TransactionType.Append)]
        [MaxLength(10)]
        public string SiteRegion { get; set; }

        /// <summary>
        /// Gets or sets the site street name.
        /// </summary>
        [ImportParameter(nameof(SiteStreet), TransactionType.Append)]
        [MaxLength(255)]
        public string SiteStreet { get; set; }

        /// <summary>
        /// Gets or sets the site street number.
        /// </summary>
        [ImportParameter(nameof(SiteStreetNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteStreetNo { get; set; }

        /// <summary>
        /// Gets or sets the site postcode.
        /// </summary>
        [ImportParameter(nameof(SitePostcode), TransactionType.Append)]
        [MaxLength(20)]
        public string SitePostcode { get; set; }

        /// <summary>
        /// Gets or sets the site city.
        /// </summary>
        [ImportParameter(nameof(SiteCity), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteCity { get; set; }

        /// <summary>
        /// Gets or sets the site county.
        /// </summary>
        [ImportParameter(nameof(SiteCounty), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteCounty { get; set; }

        /// <summary>
        /// Gets or sets the site state.
        /// </summary>
        [ImportParameter(nameof(SiteState), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteState { get; set; }

        /// <summary>
        /// Gets or sets the site country.
        /// </summary>
        [ImportParameter(nameof(SiteCountry), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteCountry { get; set; }

        /// <summary>
        /// Gets or sets the site from number.
        /// </summary>
        [ImportParameter(nameof(SiteFromNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteFromNo { get; set; }

        /// <summary>
        /// Gets or sets the site from name.
        /// </summary>
        [ImportParameter(nameof(SiteFromName), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromName { get; set; }

        /// <summary>
        /// Gets or sets the site from address.
        /// </summary>
        [ImportParameter(nameof(SiteFromAddress), TransactionType.Append)]
        public string SiteFromAddress { get; set; }

        /// <summary>
        /// Gets or sets the site from address longitude coordinate.
        /// </summary>
        [ImportParameter(nameof(SiteFromAddressGeoLong), TransactionType.Append)]
        public decimal? SiteFromAddressGeoLong { get; set; }

        /// <summary>
        /// Gets or sets the site from address latitude coordinate.
        /// </summary>
        [ImportParameter(nameof(SiteFromAddressGeoLat), TransactionType.Append)]
        public decimal? SiteFromAddressGeoLat { get; set; }

        /// <summary>
        /// Gets or sets the site from phone number.
        /// </summary>
        [ImportParameter(nameof(SiteFromPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromPhone { get; set; }

        /// <summary>
        /// Gets or sets the site from email address.
        /// </summary>
        [ImportParameter(nameof(SiteFromEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromEmail { get; set; }

        /// <summary>
        /// Gets or sets the site from region.
        /// </summary>
        [ImportParameter(nameof(SiteFromRegion), TransactionType.Append)]
        [MaxLength(10)]
        public string SiteFromRegion { get; set; }

        /// <summary>
        /// Gets or sets the site from street name.
        /// </summary>
        [ImportParameter(nameof(SiteFromStreet), TransactionType.Append)]
        [MaxLength(255)]
        public string SiteFromStreet { get; set; }

        /// <summary>
        /// Gets or sets the site from street number.
        /// </summary>
        [ImportParameter(nameof(SiteFromStreetNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteFromStreetNo { get; set; }

        /// <summary>
        /// Gets or sets the site from postcode.
        /// </summary>
        [ImportParameter(nameof(SiteFromPostcode), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteFromPostcode { get; set; }

        /// <summary>
        /// Gets or sets the site from city.
        /// </summary>
        [ImportParameter(nameof(SiteFromCity), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromCity { get; set; }

        /// <summary>
        /// Gets or sets the site from county.
        /// </summary>
        [ImportParameter(nameof(SiteFromCounty), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromCounty { get; set; }

        /// <summary>
        /// Gets or sets the site from state.
        /// </summary>
        [ImportParameter(nameof(SiteFromState), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromState { get; set; }

        /// <summary>
        /// Gets or sets the site from country.
        /// </summary>
        [ImportParameter(nameof(SiteFromCountry), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromCountry { get; set; }

        /// <summary>
        /// Gets or sets the billing number.
        /// </summary>
        [ImportParameter(nameof(BillNo), TransactionType.Append)]
        [MaxLength(20)]
        public string BillNo { get; set; }

        /// <summary>
        /// Gets or sets the billing name.
        /// </summary>
        [ImportParameter(nameof(BillName), TransactionType.Append)]
        [MaxLength(50)]
        public string BillName { get; set; }

        /// <summary>
        /// Gets or sets the billing address.
        /// </summary>
        [ImportParameter(nameof(BillAddress), TransactionType.Append)]
        public string BillAddress { get; set; }

        /// <summary>
        /// Gets or sets the billing address longitude coordinate.
        /// </summary>
        [ImportParameter(nameof(BillAddressGeoLong), TransactionType.Append)]
        public decimal? BillAddressGeoLong { get; set; }

        /// <summary>
        /// Gets or sets the billing address latitude coordinate.
        /// </summary>
        [ImportParameter(nameof(BillAddressGeoLat), TransactionType.Append)]
        public decimal? BillAddressGeoLat { get; set; }

        /// <summary>
        /// Gets or sets the billing phone number.
        /// </summary>
        [ImportParameter(nameof(BillPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string BillPhone { get; set; }

        /// <summary>
        /// Gets or sets the billing email address.
        /// </summary>
        [ImportParameter(nameof(BillEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string BillEmail { get; set; }

        /// <summary>
        /// Gets or sets the billing region.
        /// </summary>
        [ImportParameter(nameof(BillRegion), TransactionType.Append)]
        [MaxLength(10)]
        public string BillRegion { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Importance/*'/>
        [ImportParameter(nameof(Importance), TransactionType.Append)]
        public Importance Importance { get; set; }

        /// <summary>
        /// Gets or sets the creation date and time of the job.
        /// </summary>
        [ImportParameter(nameof(CreationDateTime), TransactionType.Append)]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Gets or sets the customer reference number.
        /// </summary>
        [ImportParameter(nameof(CustomerReference), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the language code.
        /// </summary>
        [ImportParameter(nameof(Language), TransactionType.Append)]
        [MaxLength(10)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the responsible person for the job.
        /// </summary>
        [ImportParameter(nameof(Responsible), TransactionType.Append)]
        [MaxLength(50)]
        public string Responsible { get; set; }

        /// <summary>
        /// Gets or sets the creator of the job.
        /// </summary>
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

        /// <summary>
        /// Gets or sets a value indicating whether manual selection is enabled.
        /// </summary>
        [ImportParameter(nameof(EnableManualSelection), TransactionType.Append)]
        public bool EnableManualSelection { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the job is available in Gantt view.
        /// </summary>
        [ImportParameter(nameof(AvailableInGantt), TransactionType.Append)]
        public bool AvailableInGantt { get; set; }

        /// <summary>
        /// Gets or sets the start date of the job.
        /// </summary>
        [ImportParameter(nameof(StartDate), TransactionType.Append)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of the job.
        /// </summary>
        [ImportParameter(nameof(EndDate), TransactionType.Append)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether dependencies are allowed.
        /// </summary>
        [ImportParameter(nameof(AllowDependencies), TransactionType.Append)]
        public bool AllowDependencies { get; set; } = true;

        /// <summary>
        /// Gets or sets the note for the job.
        /// </summary>
        [ImportParameter(nameof(Note), TransactionType.Append)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to override Gantt planning.
        /// </summary>
        [ImportParameter(nameof(OverRuleGanttPlanning), TransactionType.Append)]
        public bool OverRuleGanttPlanning { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to check appointments when deleting.
        /// </summary>
        [ImportParameter(nameof(CheckAppointments), TransactionType.Delete)]
        public bool CheckAppointments { get; set; } = true;

        /// <include file='docs.xml' path='docs/members[@name="Common"]/SentFromBackOffice/*'/>
        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool SentFromBackOffice { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the job is read-only.
        /// </summary>
        [ImportParameter(nameof(ReadOnly), TransactionType.Append)]
        public bool ReadOnly { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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