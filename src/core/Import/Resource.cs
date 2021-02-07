﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Resource : IImportRequestable, IValidatableImportRequest<Resource>
    {
        [Required]
        [ImportParameter(nameof(ResourceNo), TransactionType.Append)]
        public string ResourceNo { get; set; }

        [ImportParameter(nameof(SourceApp), TransactionType.Append)]
        public string SourceApp { get; set; }

        [ImportParameter(nameof(SourceType), TransactionType.Append)]
        public string SourceType { get; set; }

        [ImportParameter(nameof(ResourceType), TransactionType.Append)]
        public string ResourceType { get; set; }

        [ImportParameter(nameof(ResourceTypeId), TransactionType.Append)]
        public int? ResourceTypeId { get; set; }

        [ImportParameter(nameof(ResourceName), TransactionType.Append)]
        public string ResourceName { get; set; }

        [ImportParameter(nameof(DisplayName), TransactionType.Append)]
        public string DisplayName { get; set; }

        [ImportParameter(nameof(Department), TransactionType.Append)]
        public string Department { get; set; }

        [ImportParameter(nameof(Email), TransactionType.Append)]
        public string Email { get; set; }

        [ImportParameter(nameof(Phone), TransactionType.Append)]
        public string Phone { get; set; }

        [ImportParameter(nameof(MobilePhone), TransactionType.Append)]
        public string MobilePhone { get; set; }

        [ImportParameter(nameof(ReplacementResource), TransactionType.Append)]
        public string ReplacementResource { get; set; }

        [ImportParameter(nameof(FieldServiceEmail), TransactionType.Append)]
        public string FieldServiceEmail { get; set; }

        [ImportParameter(nameof(PersonalEmail), TransactionType.Append)]
        public string PersonalEmail { get; set; }

        [ImportParameter(nameof(GpsTrackingResourceNo), TransactionType.Append)]
        public string GpsTrackingResourceNo { get; set; }

        [ImportParameter(nameof(HomeAddress), TransactionType.Append)]
        public string HomeAddress { get; set; }

        [ImportParameter(nameof(HomeAddressGeoLong), TransactionType.Append)]
        public float HomeAddressGeoLong { get; set; }

        [ImportParameter(nameof(HomeAddressGeoLat), TransactionType.Append)]
        public float HomeAddressGeoLat { get; set; }

        [ImportParameter(nameof(HomePhone), TransactionType.Append)]
        public string HomePhone { get; set; }

        [ImportParameter(nameof(HomeEmail), TransactionType.Append)]
        public string HomeEmail { get; set; }

        [ImportParameter(nameof(HomeRegion), TransactionType.Append)]
        public string HomeRegion { get; set; }

        [ImportParameter(nameof(HomePostcode), TransactionType.Append)]
        public string HomePostcode { get; set; }

        [ImportParameter(nameof(HomeCity), TransactionType.Append)]
        public string HomeCity { get; set; }

        [ImportParameter(nameof(HomeCounty), TransactionType.Append)]
        public string HomeCounty { get; set; }

        [ImportParameter(nameof(HomeState), TransactionType.Append)]
        public string HomeState { get; set; }

        [ImportParameter(nameof(HomeCountry), TransactionType.Append)]
        public string HomeCountry { get; set; }

        [ImportParameter(nameof(TeamCode), TransactionType.Append)]
        public string TeamCode { get; set; }

        [ImportParameter(nameof(TeamName), TransactionType.Append)]
        public string TeamName { get; set; }

        [ImportParameter(nameof(TeamType), TransactionType.Append)]
        public string TeamType { get; set; }

        [ImportParameter(nameof(TeamSort), TransactionType.Append)]
        public int TeamSort { get; set; }

        [ImportParameter(nameof(TeamMemberType), TransactionType.Append)]
        public string TeamMemberType { get; set; }

        [ImportParameter(nameof(TeamMemberSort), TransactionType.Append)]
        public int TeamMemberSort { get; set; }

        [ImportParameter(nameof(DoNotShow), TransactionType.Append)]
        public string DoNotShow { get; set; }

        [ImportParameter(nameof(InServiceFrom), TransactionType.Append)]
        public DateTime? InServiceFrom { get; set; }

        [ImportParameter(nameof(InServiceTill), TransactionType.Append)]
        public DateTime? InServiceTill { get; set; }

        [ImportParameter(nameof(ExchangeIntegrationEnabled), TransactionType.Append)]
        public bool ExchangeIntegrationEnabled { get; set; }

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

        [ImportParameter(nameof(BulkPlanning), TransactionType.Append)]
        public bool BulkPlanning { get; set; }

        [ImportParameter(nameof(BulkCapacity), TransactionType.Append)]
        public decimal BulkCapacity { get; set; }

        [ImportParameter(nameof(ResourceGpsTrackingEnabled), TransactionType.Append)]
        public bool ResourceGpsTrackingEnabled { get; set; }

        [ImportParameter(nameof(Pin), TransactionType.Append)]
        public string Pin { get; set; }

        [ImportParameter(nameof(FreeText1), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText1 { get; set; }

        [ImportParameter(nameof(FreeText2), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText2 { get; set; }

        [ImportParameter(nameof(FreeText3), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText3 { get; set; }

        [ImportParameter(nameof(FreeText4), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText4 { get; set; }

        [ImportParameter(nameof(FreeText5), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText5 { get; set; }

        [ImportParameter(nameof(FreeText6), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText6 { get; set; }

        [ImportParameter(nameof(FreeText7), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText7 { get; set; }

        [ImportParameter(nameof(FreeText8), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText8 { get; set; }

        [ImportParameter(nameof(FreeText9), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText9 { get; set; }

        [ImportParameter(nameof(FreeText10), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText10 { get; set; }

        [ImportParameter(nameof(FreeText11), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText11 { get; set; }

        [ImportParameter(nameof(FreeText12), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText12 { get; set; }

        [ImportParameter(nameof(FreeText13), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText13 { get; set; }

        [ImportParameter(nameof(FreeText14), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText14 { get; set; }

        [ImportParameter(nameof(FreeText15), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText15 { get; set; }

        [ImportParameter(nameof(FreeText16), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText16 { get; set; }

        [ImportParameter(nameof(FreeText17), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText17 { get; set; }

        [ImportParameter(nameof(FreeText18), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText18 { get; set; }

        [ImportParameter(nameof(FreeText19), TransactionType.Append)]
        [MaxLength(100)]
        public string FreeText19 { get; set; }

        [ImportParameter(nameof(FreeText20), TransactionType.Append)]
        [MaxLength(100)]
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

        [ImportParameter(nameof(FreeDate1), TransactionType.Append)]
        public DateTime? FreeDate1 { get; set; }

        [ImportParameter(nameof(FreeDate2), TransactionType.Append)]
        public DateTime? FreeDate2 { get; set; }

        [ImportParameter(nameof(FreeDate3), TransactionType.Append)]
        public DateTime? FreeDate3 { get; set; }

        [ImportParameter(nameof(FreeDate4), TransactionType.Append)]
        public DateTime? FreeDate4 { get; set; }

        [ImportParameter(nameof(FreeDate5), TransactionType.Append)]
        public DateTime? FreeDate5 { get; set; }

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

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
           => transactionType switch
           {
               TransactionType.Append => ((IValidatableImportRequest<Resource>)this).Validate(transactionType).CreateAppendRequest(),
               TransactionType.Delete => ((IValidatableImportRequest<Resource>)this).Validate(transactionType).CreateDeleteRequest(),
               _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
           };

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(ImportProcedures.Resource.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(ImportProcedures.Resource.Delete, this.CreateParameters(TransactionType.Delete));

        Resource IValidatableImportRequest<Resource>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Resource>(validationContext);
    }
}