using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// A job is a meta entity that holds information such as customer, contact, addresses, and more.
    /// </summary>
    public class Job : IImportEntity, IValidatableImportRequest<Job>
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
        [Required]
        [MaxLength(50)]
        public string JobNo { get; set; }

        /// <summary>
        /// The short description of the job.
        /// </summary>
        [Description("the short description of the job.")]
        [ImportParameter(nameof(ShortDescription), TransactionType.Append)]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(50)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// The description of the job.
        /// </summary>
        [Description("the description of the job.")]
        [ImportParameter(nameof(Description), TransactionType.Append)]
        public string Description { get; set; }

        /// <summary>
        /// The type of the job.
        /// </summary>
        [Description("the type of the job.")]
        [ImportParameter(nameof(Type), TransactionType.Append)]
        [MaxLength(50)]
        public string Type { get; set; }

        /// <summary>
        /// The name of the job.
        /// </summary>
        [Description("the name of the job.")]
        [ImportParameter(nameof(Name), TransactionType.Append)]
        [MaxLength(255)]
        public string Name { get; set; }

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
        /// The customer number.
        /// </summary>
        [Description("the customer number.")]
        [ImportParameter(nameof(CustomerNo), TransactionType.Append)]
        [MaxLength(20)]
        public string CustomerNo { get; set; }

        /// <summary>
        /// The customer name.
        /// </summary>
        [Description("the customer name.")]
        [ImportParameter(nameof(CustomerName), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        /// <summary>
        /// The customer address.
        /// </summary>
        [Description("the customer address.")]
        [ImportParameter(nameof(CustomerAddress), TransactionType.Append)]
        public string CustomerAddress { get; set; }

        /// <summary>
        /// The customer address longitude coordinate.
        /// </summary>
        [Description("the customer address longitude coordinate.")]
        [ImportParameter(nameof(CustomerAddressGeoLong), TransactionType.Append)]
        public decimal? CustomerAddressGeoLong { get; set; }

        /// <summary>
        /// The customer address latitude coordinate.
        /// </summary>
        [Description("the customer address latitude coordinate.")]
        [ImportParameter(nameof(CustomerAddressGeoLat), TransactionType.Append)]
        public decimal? CustomerAddressGeoLat { get; set; }

        /// <summary>
        /// The customer phone number.
        /// </summary>
        [Description("the customer phone number.")]
        [ImportParameter(nameof(CustomerPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerPhone { get; set; }

        /// <summary>
        /// The customer email address.
        /// </summary>
        [Description("the customer email address.")]
        [ImportParameter(nameof(CustomerEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// The contact number.
        /// </summary>
        [Description("the contact number.")]
        [ImportParameter(nameof(ContactNo), TransactionType.Append)]
        [MaxLength(20)]
        public string ContactNo { get; set; }

        /// <summary>
        /// The contact name.
        /// </summary>
        [Description("the contact name.")]
        [ImportParameter(nameof(ContactName), TransactionType.Append)]
        [MaxLength(50)]
        public string ContactName { get; set; }

        /// <summary>
        /// The contact address.
        /// </summary>
        [Description("the contact address.")]
        [ImportParameter(nameof(ContactAddress), TransactionType.Append)]
        public string ContactAddress { get; set; }

        /// <summary>
        /// The contact address longitude coordinate.
        /// </summary>
        [Description("the contact address longitude coordinate.")]
        [ImportParameter(nameof(ContactAddressGeoLong), TransactionType.Append)]
        public decimal? ContactAddressGeoLong { get; set; }

        /// <summary>
        /// The contact address latitude coordinate.
        /// </summary>
        [Description("the contact address latitude coordinate.")]
        [ImportParameter(nameof(ContactAddressGeoLat), TransactionType.Append)]
        public decimal? ContactAddressGeoLat { get; set; }

        /// <summary>
        /// The contact phone number.
        /// </summary>
        [Description("the contact phone number.")]
        [ImportParameter(nameof(ContactPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// The contact email address.
        /// </summary>
        [Description("the contact email address.")]
        [ImportParameter(nameof(ContactEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// The site number.
        /// </summary>
        [Description("the site number.")]
        [ImportParameter(nameof(SiteNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteNo { get; set; }

        /// <summary>
        /// The site name.
        /// </summary>
        [Description("the site name.")]
        [ImportParameter(nameof(SiteName), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteName { get; set; }

        /// <summary>
        /// The site address.
        /// </summary>
        [Description("the site address.")]
        [ImportParameter(nameof(SiteAddress), TransactionType.Append)]
        public string SiteAddress { get; set; }

        /// <summary>
        /// The site address longitude coordinate.
        /// </summary>
        [Description("the site address longitude coordinate.")]
        [ImportParameter(nameof(SiteAddressGeoLong), TransactionType.Append)]
        public decimal? SiteAddressGeoLong { get; set; }

        /// <summary>
        /// The site address latitude coordinate.
        /// </summary>
        [Description("the site address latitude coordinate.")]
        [ImportParameter(nameof(SiteAddressGeoLat), TransactionType.Append)]
        public decimal? SiteAddressGeoLat { get; set; }

        /// <summary>
        /// The site phone number.
        /// </summary>
        [Description("the site phone number.")]
        [ImportParameter(nameof(SitePhone), TransactionType.Append)]
        [MaxLength(50)]
        public string SitePhone { get; set; }

        /// <summary>
        /// The site email address.
        /// </summary>
        [Description("the site email address.")]
        [ImportParameter(nameof(SiteEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteEmail { get; set; }

        /// <summary>
        /// The site region.
        /// </summary>
        [Description("the site region.")]
        [ImportParameter(nameof(SiteRegion), TransactionType.Append)]
        [MaxLength(10)]
        public string SiteRegion { get; set; }

        /// <summary>
        /// The site street name.
        /// </summary>
        [Description("the site street name.")]
        [ImportParameter(nameof(SiteStreet), TransactionType.Append)]
        [MaxLength(255)]
        public string SiteStreet { get; set; }

        /// <summary>
        /// The site street number.
        /// </summary>
        [Description("the site street number.")]
        [ImportParameter(nameof(SiteStreetNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteStreetNo { get; set; }

        /// <summary>
        /// The site postcode.
        /// </summary>
        [Description("the site postcode.")]
        [ImportParameter(nameof(SitePostcode), TransactionType.Append)]
        [MaxLength(20)]
        public string SitePostcode { get; set; }

        /// <summary>
        /// The site city.
        /// </summary>
        [Description("the site city.")]
        [ImportParameter(nameof(SiteCity), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteCity { get; set; }

        /// <summary>
        /// The site county.
        /// </summary>
        [Description("the site county.")]
        [ImportParameter(nameof(SiteCounty), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteCounty { get; set; }

        /// <summary>
        /// The site state.
        /// </summary>
        [Description("the site state.")]
        [ImportParameter(nameof(SiteState), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteState { get; set; }

        /// <summary>
        /// The site country.
        /// </summary>
        [Description("the site country.")]
        [ImportParameter(nameof(SiteCountry), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteCountry { get; set; }

        /// <summary>
        /// The site from number.
        /// </summary>
        [Description("the site from number.")]
        [ImportParameter(nameof(SiteFromNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteFromNo { get; set; }

        /// <summary>
        /// The site from name.
        /// </summary>
        [Description("the site from name.")]
        [ImportParameter(nameof(SiteFromName), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromName { get; set; }

        /// <summary>
        /// The site from address.
        /// </summary>
        [Description("the site from address.")]
        [ImportParameter(nameof(SiteFromAddress), TransactionType.Append)]
        public string SiteFromAddress { get; set; }

        /// <summary>
        /// The site from address longitude coordinate.
        /// </summary>
        [Description("the site from address longitude coordinate.")]
        [ImportParameter(nameof(SiteFromAddressGeoLong), TransactionType.Append)]
        public decimal? SiteFromAddressGeoLong { get; set; }

        /// <summary>
        /// The site from address latitude coordinate.
        /// </summary>
        [Description("the site from address latitude coordinate.")]
        [ImportParameter(nameof(SiteFromAddressGeoLat), TransactionType.Append)]
        public decimal? SiteFromAddressGeoLat { get; set; }

        /// <summary>
        /// The site from phone number.
        /// </summary>
        [Description("the site from phone number.")]
        [ImportParameter(nameof(SiteFromPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromPhone { get; set; }

        /// <summary>
        /// The site from email address.
        /// </summary>
        [Description("the site from email address.")]
        [ImportParameter(nameof(SiteFromEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromEmail { get; set; }

        /// <summary>
        /// The site from region.
        /// </summary>
        [Description("the site from region.")]
        [ImportParameter(nameof(SiteFromRegion), TransactionType.Append)]
        [MaxLength(10)]
        public string SiteFromRegion { get; set; }

        /// <summary>
        /// The site from street name.
        /// </summary>
        [Description("the site from street name.")]
        [ImportParameter(nameof(SiteFromStreet), TransactionType.Append)]
        [MaxLength(255)]
        public string SiteFromStreet { get; set; }

        /// <summary>
        /// The site from street number.
        /// </summary>
        [Description("the site from street number.")]
        [ImportParameter(nameof(SiteFromStreetNo), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteFromStreetNo { get; set; }

        /// <summary>
        /// The site from postcode.
        /// </summary>
        [Description("the site from postcode.")]
        [ImportParameter(nameof(SiteFromPostcode), TransactionType.Append)]
        [MaxLength(20)]
        public string SiteFromPostcode { get; set; }

        /// <summary>
        /// The site from city.
        /// </summary>
        [Description("the site from city.")]
        [ImportParameter(nameof(SiteFromCity), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromCity { get; set; }

        /// <summary>
        /// The site from county.
        /// </summary>
        [Description("the site from county.")]
        [ImportParameter(nameof(SiteFromCounty), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromCounty { get; set; }

        /// <summary>
        /// The site from state.
        /// </summary>
        [Description("the site from state.")]
        [ImportParameter(nameof(SiteFromState), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromState { get; set; }

        /// <summary>
        /// The site from country.
        /// </summary>
        [Description("the site from country.")]
        [ImportParameter(nameof(SiteFromCountry), TransactionType.Append)]
        [MaxLength(50)]
        public string SiteFromCountry { get; set; }

        /// <summary>
        /// The billing number.
        /// </summary>
        [Description("the billing number.")]
        [ImportParameter(nameof(BillNo), TransactionType.Append)]
        [MaxLength(20)]
        public string BillNo { get; set; }

        /// <summary>
        /// The billing name.
        /// </summary>
        [Description("the billing name.")]
        [ImportParameter(nameof(BillName), TransactionType.Append)]
        [MaxLength(50)]
        public string BillName { get; set; }

        /// <summary>
        /// The billing address.
        /// </summary>
        [Description("the billing address.")]
        [ImportParameter(nameof(BillAddress), TransactionType.Append)]
        public string BillAddress { get; set; }

        /// <summary>
        /// The billing address longitude coordinate.
        /// </summary>
        [Description("the billing address longitude coordinate.")]
        [ImportParameter(nameof(BillAddressGeoLong), TransactionType.Append)]
        public decimal? BillAddressGeoLong { get; set; }

        /// <summary>
        /// The billing address latitude coordinate.
        /// </summary>
        [Description("the billing address latitude coordinate.")]
        [ImportParameter(nameof(BillAddressGeoLat), TransactionType.Append)]
        public decimal? BillAddressGeoLat { get; set; }

        /// <summary>
        /// The billing phone number.
        /// </summary>
        [Description("the billing phone number.")]
        [ImportParameter(nameof(BillPhone), TransactionType.Append)]
        [MaxLength(50)]
        public string BillPhone { get; set; }

        /// <summary>
        /// The billing email address.
        /// </summary>
        [Description("the billing email address.")]
        [ImportParameter(nameof(BillEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string BillEmail { get; set; }

        /// <summary>
        /// The billing region.
        /// </summary>
        [Description("the billing region.")]
        [ImportParameter(nameof(BillRegion), TransactionType.Append)]
        [MaxLength(10)]
        public string BillRegion { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Importance/*'/>
        [Description("the importance level.")]
        [ImportParameter(nameof(Importance), TransactionType.Append)]
        public Importance Importance { get; set; }

        /// <summary>
        /// The creation date and time of the job.
        /// </summary>
        [Description("the creation date and time of the job.")]
        [ImportParameter(nameof(CreationDateTime), TransactionType.Append)]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// The customer reference number.
        /// </summary>
        [Description("the customer reference number.")]
        [ImportParameter(nameof(CustomerReference), TransactionType.Append)]
        [MaxLength(50)]
        public string CustomerReference { get; set; }

        /// <summary>
        /// The language code.
        /// </summary>
        [Description("the language code.")]
        [ImportParameter(nameof(Language), TransactionType.Append)]
        [MaxLength(10)]
        public string Language { get; set; }

        /// <summary>
        /// The responsible person for the job.
        /// </summary>
        [Description("the responsible person for the job.")]
        [ImportParameter(nameof(Responsible), TransactionType.Append)]
        [MaxLength(50)]
        public string Responsible { get; set; }

        /// <summary>
        /// The creator of the job.
        /// </summary>
        [Description("the creator of the job.")]
        [ImportParameter(nameof(Creator), TransactionType.Append)]
        [MaxLength(50)]
        public string Creator { get; set; }

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

        /// <summary>
        /// Indicates whether manual selection is enabled.
        /// </summary>
        [Description("Indicates whether manual selection is enabled.")]
        [ImportParameter(nameof(EnableManualSelection), TransactionType.Append)]
        public bool EnableManualSelection { get; set; }

        /// <summary>
        /// Indicates whether the job is available in Gantt view.
        /// </summary>
        [Description("Indicates whether the job is available in Gantt view.")]
        [ImportParameter(nameof(AvailableInGantt), TransactionType.Append)]
        public bool AvailableInGantt { get; set; }

        /// <summary>
        /// The start date of the job.
        /// </summary>
        [Description("the start date of the job.")]
        [ImportParameter(nameof(StartDate), TransactionType.Append)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of the job.
        /// </summary>
        [Description("the end date of the job.")]
        [ImportParameter(nameof(EndDate), TransactionType.Append)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Indicates whether dependencies are allowed.
        /// </summary>
        [Description("Indicates whether dependencies are allowed.")]
        [ImportParameter(nameof(AllowDependencies), TransactionType.Append)]
        public bool AllowDependencies { get; set; } = true;

        /// <summary>
        /// The note for the job.
        /// </summary>
        [Description("the note for the job.")]
        [ImportParameter(nameof(Note), TransactionType.Append)]
        public string Note { get; set; }

        /// <summary>
        /// Indicates whether to override Gantt planning.
        /// </summary>
        [Description("Indicates whether to override Gantt planning.")]
        [ImportParameter(nameof(OverRuleGanttPlanning), TransactionType.Append)]
        public bool OverRuleGanttPlanning { get; set; }

        /// <summary>
        /// Indicates whether to check appointments when deleting.
        /// </summary>
        [Description("Indicates whether to check appointments when deleting.")]
        [ImportParameter(nameof(CheckAppointments), TransactionType.Delete)]
        public bool CheckAppointments { get; set; } = true;

        /// <include file='docs.xml' path='docs/members[@name="Common"]/SentFromBackOffice/*'/>
        [Description("Indicates whether the request was sent from back office.")]
        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool SentFromBackOffice { get; set; } = true;

        /// <summary>
        /// Indicates whether the job is read-only.
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