using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class Resource : IImportEntity, IValidatableImportRequest<Resource>
    {
        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [Description("the resource number.")]
        [ImportParameter(nameof(ResourceNo), TransactionType.Append)]
        [Required]
        [MaxLength(50)]
        public string ResourceNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [Description("Identifies the record's originating system.")]
        [ImportParameter(nameof(SourceApp), TransactionType.Append)]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [Description("Identifies the record's type in the originating system.")]
        [ImportParameter(nameof(SourceType), TransactionType.Append)]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <summary>
        /// The resource type.
        /// </summary>
        [Description("the resource type.")]
        [ImportParameter(nameof(ResourceType), TransactionType.Append)]
        [MaxLength(100)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The resource type identifier.
        /// </summary>
        [Description("the resource type identifier.")]
        [ImportParameter(nameof(ResourceTypeId), TransactionType.Append)]
        public int? ResourceTypeId { get; set; }

        /// <summary>
        /// The resource name.
        /// </summary>
        [Description("the resource name.")]
        [ImportParameter(nameof(ResourceName), TransactionType.Append)]
        [MaxLength(100)]
        public string ResourceName { get; set; }

        /// <summary>
        /// The display name of the resource.
        /// </summary>
        [Description("the display name of the resource.")]
        [ImportParameter(nameof(DisplayName), TransactionType.Append)]
        [MaxLength(100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The department of the resource.
        /// </summary>
        [Description("the department of the resource.")]
        [ImportParameter(nameof(Department), TransactionType.Append)]
        [MaxLength(50)]
        public string Department { get; set; }

        /// <summary>
        /// The email address of the resource.
        /// </summary>
        [Description("the email address of the resource.")]
        [ImportParameter(nameof(Email), TransactionType.Append)]
        [MaxLength(100)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the resource.
        /// </summary>
        [Description("the phone number of the resource.")]
        [ImportParameter(nameof(Phone), TransactionType.Append)]
        [MaxLength(50)]
        public string Phone { get; set; }

        /// <summary>
        /// The mobile phone number of the resource.
        /// </summary>
        [Description("the mobile phone number of the resource.")]
        [ImportParameter(nameof(MobilePhone), TransactionType.Append)]
        [MaxLength(50)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Indicates whether this is a replacement resource.
        /// </summary>
        [Description("Indicates whether this is a replacement resource.")]
        [ImportParameter(nameof(ReplacementResource), TransactionType.Append)]
        public bool ReplacementResource { get; set; }

        /// <summary>
        /// The field service email address.
        /// </summary>
        [Description("the field service email address.")]
        [ImportParameter(nameof(FieldServiceEmail), TransactionType.Append)]
        [MaxLength(100)]
        public string FieldServiceEmail { get; set; }

        /// <summary>
        /// The personal email address.
        /// </summary>
        [Description("the personal email address.")]
        [ImportParameter(nameof(PersonalEmail), TransactionType.Append)]
        [MaxLength(100)]
        public string PersonalEmail { get; set; }

        /// <summary>
        /// The GPS tracking resource number.
        /// </summary>
        [Description("the GPS tracking resource number.")]
        [ImportParameter(nameof(GpsTrackingResourceNo), TransactionType.Append)]
        [MaxLength(50)]
        public string GpsTrackingResourceNo { get; set; }

        /// <summary>
        /// The home address.
        /// </summary>
        [Description("the home address.")]
        [ImportParameter(nameof(HomeAddress), TransactionType.Append)]
        public string HomeAddress { get; set; }

        /// <summary>
        /// The home address longitude coordinate.
        /// </summary>
        [Description("the home address longitude coordinate.")]
        [ImportParameter(nameof(HomeAddressGeoLong), TransactionType.Append)]
        public decimal? HomeAddressGeoLong { get; set; }

        /// <summary>
        /// The home address latitude coordinate.
        /// </summary>
        [Description("the home address latitude coordinate.")]
        [ImportParameter(nameof(HomeAddressGeoLat), TransactionType.Append)]
        public decimal? HomeAddressGeoLat { get; set; }

        /// <summary>
        /// The home phone number.
        /// </summary>
        [Description("the home phone number.")]
        [ImportParameter(nameof(HomePhone), TransactionType.Append)]
        [MaxLength(50)]
        public string HomePhone { get; set; }

        /// <summary>
        /// The home email address.
        /// </summary>
        [Description("the home email address.")]
        [ImportParameter(nameof(HomeEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string HomeEmail { get; set; }

        /// <summary>
        /// The home street name.
        /// </summary>
        [Description("the home street name.")]
        [ImportParameter(nameof(HomeStreet), TransactionType.Append)]
        [MaxLength(255)]
        public string HomeStreet { get; set; }

        /// <summary>
        /// The home street number.
        /// </summary>
        [Description("the home street number.")]
        [ImportParameter(nameof(HomeStreetNo), TransactionType.Append)]
        [MaxLength(20)]
        public string HomeStreetNo { get; set; }

        /// <summary>
        /// The home postcode.
        /// </summary>
        [Description("the home postcode.")]
        [ImportParameter(nameof(HomePostcode), TransactionType.Append)]
        [MaxLength(20)]
        public string HomePostcode { get; set; }

        /// <summary>
        /// The home city.
        /// </summary>
        [Description("the home city.")]
        [ImportParameter(nameof(HomeCity), TransactionType.Append)]
        [MaxLength(50)]
        public string HomeCity { get; set; }

        /// <summary>
        /// The home county.
        /// </summary>
        [Description("the home county.")]
        [ImportParameter(nameof(HomeCounty), TransactionType.Append)]
        [MaxLength(50)]
        public string HomeCounty { get; set; }

        /// <summary>
        /// The home state.
        /// </summary>
        [Description("the home state.")]
        [ImportParameter(nameof(HomeState), TransactionType.Append)]
        [MaxLength(50)]
        public string HomeState { get; set; }

        /// <summary>
        /// The home country.
        /// </summary>
        [Description("the home country.")]
        [ImportParameter(nameof(HomeCountry), TransactionType.Append)]
        [MaxLength(50)]
        public string HomeCountry { get; set; }

        /// <summary>
        /// The home region.
        /// </summary>
        [Description("the home region.")]
        [ImportParameter(nameof(HomeRegion), TransactionType.Append)]
        [MaxLength(10)]
        public string HomeRegion { get; set; }

        /// <summary>
        /// The team code.
        /// </summary>
        [Description("the team code.")]
        [ImportParameter(nameof(TeamCode), TransactionType.Append)]
        [MaxLength(20)]
        public string TeamCode { get; set; }

        /// <summary>
        /// The team name.
        /// </summary>
        [Description("the team name.")]
        [ImportParameter(nameof(TeamName), TransactionType.Append)]
        [MaxLength(100)]
        public string TeamName { get; set; }

        /// <summary>
        /// The team type.
        /// </summary>
        [Description("the team type.")]
        [ImportParameter(nameof(TeamType), TransactionType.Append)]
        [MaxLength(20)]
        public string TeamType { get; set; }

        /// <summary>
        /// The team sort order.
        /// </summary>
        [Description("the team sort order.")]
        [ImportParameter(nameof(TeamSort), TransactionType.Append)]
        public int TeamSort { get; set; }

        /// <summary>
        /// The team member type.
        /// </summary>
        [Description("the team member type.")]
        [ImportParameter(nameof(TeamMemberType), TransactionType.Append)]
        [MaxLength(20)]
        public string TeamMemberType { get; set; }

        /// <summary>
        /// The team member sort order.
        /// </summary>
        [Description("the team member sort order.")]
        [ImportParameter(nameof(TeamMemberSort), TransactionType.Append)]
        public int TeamMemberSort { get; set; }

        /// <summary>
        /// Indicates whether the resource should not be shown.
        /// </summary>
        [Description("Indicates whether the resource should not be shown.")]
        [ImportParameter(nameof(DoNotShow), TransactionType.Append)]
        public bool DoNotShow { get; set; }

        /// <summary>
        /// The date and time when the resource is in service from.
        /// </summary>
        [Description("the date and time when the resource is in service from.")]
        [ImportParameter(nameof(InServiceFrom), TransactionType.Append)]
        public DateTime? InServiceFrom { get; set; }

        /// <summary>
        /// The date and time when the resource is in service till.
        /// </summary>
        [Description("the date and time when the resource is in service till.")]
        [ImportParameter(nameof(InServiceTill), TransactionType.Append)]
        public DateTime? InServiceTill { get; set; }

        /// <summary>
        /// Indicates whether Exchange integration is enabled.
        /// </summary>
        [Description("Indicates whether Exchange integration is enabled.")]
        [ImportParameter(nameof(ExchangeIntegrationEnabled), TransactionType.Append)]
        public bool ExchangeIntegrationEnabled { get; set; }

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
        [MaxLength(1000)]
        [ImportParameter("url3", TransactionType.Append)]
        public string Url3 { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [Description("the description of the URI.")]
        [ImportParameter("urldesc3", TransactionType.Append)]
        [MaxLength(255)]
        public string UrlDescription3 { get; set; }

        /// <summary>
        /// Indicates whether bulk planning is enabled.
        /// </summary>
        [Description("Indicates whether bulk planning is enabled.")]
        [ImportParameter(nameof(BulkPlanning), TransactionType.Append)]
        public bool BulkPlanning { get; set; }

        /// <summary>
        /// The bulk capacity.
        /// </summary>
        [Description("the bulk capacity.")]
        [ImportParameter(nameof(BulkCapacity), TransactionType.Append)]
        public decimal BulkCapacity { get; set; }

        /// <summary>
        /// Indicates whether GPS tracking is enabled for the resource.
        /// </summary>
        [Description("Indicates whether GPS tracking is enabled for the resource.")]
        [ImportParameter(nameof(ResourceGpsTrackingEnabled), TransactionType.Append)]
        public bool ResourceGpsTrackingEnabled { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Pin/*'/>
        [Description("the pin indicator.")]
        [ImportParameter(nameof(Pin), TransactionType.Append)]
        [MaxLength(100)]
        public string Pin { get; set; }

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

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
           => transactionType switch
           {
               TransactionType.Append => ((IValidatableImportRequest<Resource>)this).Validate(transactionType).CreateAppendRequest(),
               TransactionType.Delete => ((IValidatableImportRequest<Resource>)this).Validate(transactionType).CreateDeleteRequest(),
               _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
           };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Resource.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Resource.Delete, this.CreateParameters(TransactionType.Delete));

        Resource IValidatableImportRequest<Resource>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Resource>(validationContext);
    }
}