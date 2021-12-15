using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Resource : IImportRequestable, IValidatableImportRequest<Resource>
    {
        [ImportParameter(nameof(ResourceNo), TransactionType.Append)]
        [Required]
        [MaxLength(50)]
        public string ResourceNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter(nameof(SourceApp), TransactionType.Append)]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter(nameof(SourceType), TransactionType.Append)]
        [MaxLength(10)]
        public string SourceType { get; set; }

        [ImportParameter(nameof(ResourceType), TransactionType.Append)]
        [MaxLength(100)]
        public string ResourceType { get; set; }

        [ImportParameter(nameof(ResourceTypeId), TransactionType.Append)]
        public int? ResourceTypeId { get; set; }

        [ImportParameter(nameof(ResourceName), TransactionType.Append)]
        [MaxLength(100)]
        public string ResourceName { get; set; }

        [ImportParameter(nameof(DisplayName), TransactionType.Append)]
        [MaxLength(100)]
        public string DisplayName { get; set; }

        [ImportParameter(nameof(Department), TransactionType.Append)]
        [MaxLength(50)]
        public string Department { get; set; }

        [ImportParameter(nameof(Email), TransactionType.Append)]
        [MaxLength(100)]
        public string Email { get; set; }

        [ImportParameter(nameof(Phone), TransactionType.Append)]
        [MaxLength(50)]
        public string Phone { get; set; }

        [ImportParameter(nameof(MobilePhone), TransactionType.Append)]
        [MaxLength(50)]
        public string MobilePhone { get; set; }

        [ImportParameter(nameof(ReplacementResource), TransactionType.Append)]
        public bool ReplacementResource { get; set; }

        [ImportParameter(nameof(FieldServiceEmail), TransactionType.Append)]
        [MaxLength(100)]
        public string FieldServiceEmail { get; set; }

        [ImportParameter(nameof(PersonalEmail), TransactionType.Append)]
        [MaxLength(100)]
        public string PersonalEmail { get; set; }

        [ImportParameter(nameof(GpsTrackingResourceNo), TransactionType.Append)]
        [MaxLength(50)]
        public string GpsTrackingResourceNo { get; set; }

        [ImportParameter(nameof(HomeAddress), TransactionType.Append)]
        public string HomeAddress { get; set; }

        [ImportParameter(nameof(HomeAddressGeoLong), TransactionType.Append)]
        public float? HomeAddressGeoLong { get; set; }

        [ImportParameter(nameof(HomeAddressGeoLat), TransactionType.Append)]
        public float? HomeAddressGeoLat { get; set; }

        [ImportParameter(nameof(HomePhone), TransactionType.Append)]
        [MaxLength(50)]
        public string HomePhone { get; set; }

        [ImportParameter(nameof(HomeEmail), TransactionType.Append)]
        [MaxLength(50)]
        public string HomeEmail { get; set; }

        [ImportParameter(nameof(HomeStreet), TransactionType.Append)]
        [MaxLength(255)]
        public string HomeStreet { get; set; }

        [ImportParameter(nameof(HomeStreetNo), TransactionType.Append)]
        [MaxLength(20)]
        public string HomeStreetNo { get; set; }

        [ImportParameter(nameof(HomePostcode), TransactionType.Append)]
        [MaxLength(20)]
        public string HomePostcode { get; set; }

        [ImportParameter(nameof(HomeCity), TransactionType.Append)]
        [MaxLength(50)]
        public string HomeCity { get; set; }

        [ImportParameter(nameof(HomeCounty), TransactionType.Append)]
        [MaxLength(50)]
        public string HomeCounty { get; set; }

        [ImportParameter(nameof(HomeState), TransactionType.Append)]
        [MaxLength(50)]
        public string HomeState { get; set; }

        [ImportParameter(nameof(HomeCountry), TransactionType.Append)]
        [MaxLength(50)]
        public string HomeCountry { get; set; }

        [ImportParameter(nameof(HomeRegion), TransactionType.Append)]
        [MaxLength(10)]
        public string HomeRegion { get; set; }

        [ImportParameter(nameof(TeamCode), TransactionType.Append)]
        [MaxLength(20)]
        public string TeamCode { get; set; }

        [ImportParameter(nameof(TeamName), TransactionType.Append)]
        [MaxLength(100)]
        public string TeamName { get; set; }

        [ImportParameter(nameof(TeamType), TransactionType.Append)]
        [MaxLength(20)]
        public string TeamType { get; set; }

        [ImportParameter(nameof(TeamSort), TransactionType.Append)]
        public int TeamSort { get; set; }

        [ImportParameter(nameof(TeamMemberType), TransactionType.Append)]
        [MaxLength(20)]
        public string TeamMemberType { get; set; }

        [ImportParameter(nameof(TeamMemberSort), TransactionType.Append)]
        public int TeamMemberSort { get; set; }

        [ImportParameter(nameof(DoNotShow), TransactionType.Append)]
        public bool DoNotShow { get; set; }

        [ImportParameter(nameof(InServiceFrom), TransactionType.Append)]
        public DateTime? InServiceFrom { get; set; }

        [ImportParameter(nameof(InServiceTill), TransactionType.Append)]
        public DateTime? InServiceTill { get; set; }

        [ImportParameter(nameof(ExchangeIntegrationEnabled), TransactionType.Append)]
        public bool ExchangeIntegrationEnabled { get; set; }

        [ImportParameter("url1", TransactionType.Append)]
        [MaxLength(1000)]
        public string Url1 { get; set; }

        [ImportParameter("urldesc1", TransactionType.Append)]
        [MaxLength(255)]
        public string UrlDescription1 { get; set; }

        [ImportParameter("url2", TransactionType.Append)]
        [MaxLength(1000)]
        public string Url2 { get; set; }

        [ImportParameter("urldesc2", TransactionType.Append)]
        [MaxLength(255)]
        public string UrlDescription2 { get; set; }

        [MaxLength(1000)]
        [ImportParameter("url3", TransactionType.Append)]
        public string Url3 { get; set; }

        [ImportParameter("urldesc3", TransactionType.Append)]
        [MaxLength(255)]
        public string UrlDescription3 { get; set; }

        [ImportParameter(nameof(BulkPlanning), TransactionType.Append)]
        public bool BulkPlanning { get; set; }

        [ImportParameter(nameof(BulkCapacity), TransactionType.Append)]
        public decimal BulkCapacity { get; set; }

        [ImportParameter(nameof(ResourceGpsTrackingEnabled), TransactionType.Append)]
        public bool ResourceGpsTrackingEnabled { get; set; }

        [ImportParameter(nameof(Pin), TransactionType.Append)]
        [MaxLength(100)]
        public string Pin { get; set; }

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

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
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