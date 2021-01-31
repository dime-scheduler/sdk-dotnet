using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Resource : IImportRequestable, IValidatableImportRequest<Resource>
    {
        [Required]
        public string ResourceNo { get; set; }
        public string SourceApp { get; set; }
        public string SourceType { get; set; }
        public string ResourceType { get; set; }
        public string ResourceName { get; set; }
        public string DisplayName { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string ReplacementResource { get; set; }
        public string FieldServiceEmail { get; set; }
        public string PersonalEmail { get; set; }
        public string GpsTrackingResourceNo { get; set; }
        public string HomeAddress { get; set; }
        public float HomeAddressGeoLong { get; set; }
        public float HomeAddressGeoLat { get; set; }
        public string HomePhone { get; set; }
        public string HomeEmail { get; set; }
        public string HomeRegion { get; set; }
        public string HomePostcode { get; set; }
        public string HomeCity { get; set; }
        public string HomeCount { get; set; }
        public string HomeState { get; set; }
        public string HomeCountry { get; set; }
        public string TeamCode { get; set; }
        public string TeamName { get; set; }
        public string TeamType { get; set; }
        public int TeamSort { get; set; }
        public string TeamMemberType { get; set; }
        public int TeamMemberSort { get; set; }
        public string DoNotShow { get; set; }
        public DateTime InServiceFrom { get; set; }
        public DateTime InServiceTill { get; set; }
        public bool ExchangeIntegrationEnabled { get; set; }
        public string url1 { get; set; }
        public string urldesc1 { get; set; }
        public string url2 { get; set; }
        public string urldesc2 { get; set; }
        public string url3 { get; set; }
        public string urldesc3 { get; set; }
        public bool BulkPlanning { get; set; }
        public decimal BulkCapacity { get; set; }
        public bool ResourceGpsTrackingEnabled { get; set; }
        public string Pin { get; set; }
        public bool FreeBit1 { get; set; }
        public bool FreeBit2 { get; set; }
        public bool FreeBit3 { get; set; }
        public bool FreeBit4 { get; set; }
        public bool FreeBit5 { get; set; }
        public decimal FreeDecimal1 { get; set; }
        public decimal FreeDecimal2 { get; set; }
        public decimal FreeDecimal3 { get; set; }
        public decimal FreeDecimal4 { get; set; }
        public decimal FreeDecimal5 { get; set; }
        public decimal FreeDecimal6 { get; set; }
        public decimal FreeDecimal7 { get; set; }
        public decimal FreeDecimal8 { get; set; }
        public decimal FreeDecimal9 { get; set; }
        public decimal FreeDecimal10 { get; set; }
        public DateTime FreeDate1 { get; set; }
        public DateTime FreeDate2 { get; set; }
        public DateTime FreeDate3 { get; set; }
        public DateTime FreeDate4 { get; set; }
        public DateTime FreeDate5 { get; set; }
        public string FreeText1 { get; set; }
        public string FreeText2 { get; set; }
        public string FreeText3 { get; set; }
        public string FreeText4 { get; set; }
        public string FreeText5 { get; set; }
        public string FreeText6 { get; set; }
        public string FreeText7 { get; set; }
        public string FreeText8 { get; set; }
        public string FreeText9 { get; set; }
        public string FreeText10 { get; set; }
        public string FreeText11 { get; set; }
        public string FreeText12 { get; set; }
        public string FreeText13 { get; set; }
        public string FreeText14 { get; set; }
        public string FreeText15 { get; set; }
        public string FreeText16 { get; set; }
        public string FreeText17 { get; set; }
        public string FreeText18 { get; set; }
        public string FreeText19 { get; set; }
        public string FreeText20 { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? ((IValidatableImportRequest<Resource>)this).Validate(transactionType).CreateAppendRequest()
                : ((IValidatableImportRequest<Resource>)this).Validate(transactionType).CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertResource",
                new List<string>
                {
                    "ResourceType",
                    "SourceApp",
                    "SourceType",
                    "ResourceName",
                    "DisplayName",
                    "Department",
                    "ResourceNo",
                    "Email",
                    "Phone",
                    "MobilePhone",
                    "ReplacementResource",
                    "FieldServiceEmail",
                    "PersonalEmail",
                    "GpsTrackingResourceNo",
                    "HomeAddress",
                    "HomeAddressGeoLong",
                    "HomeAddressGeoLat",
                    "HomePhone",
                    "HomeEmail",
                    "HomeRegion",
                    "HomePostcode",
                    "HomeCity",
                    "HomeCount",
                    "HomeState",
                    "HomeCountry",
                    "TeamCode",
                    "TeamName",
                    "TeamType",
                    "TeamSort",
                    "TeamMemberType",
                    "TeamMemberSort",
                    "DoNotShow",
                    "InServiceFrom",
                    "InServiceTill",
                    "ExchangeIntegrationEnabled",
                    "url1",
                    "urldesc1",
                    "url2",
                    "urldesc2",
                    "url3",
                    "urldesc3",
                    "BulkPlanning",
                    "BulkCapacity",
                    "ResourceGpsTrackingEnabled",
                    "Pin",
                    "FreeText1",
                    "FreeText2",
                    "FreeText3",
                    "FreeText4",
                    "FreeText5",
                    "FreeText6",
                    "FreeText7",
                    "FreeText8",
                    "FreeText9",
                    "FreeText10",
                    "FreeText11",
                    "FreeText12",
                    "FreeText13",
                    "FreeText14",
                    "FreeText15",
                    "FreeText16",
                    "FreeText17",
                    "FreeText18",
                    "FreeText19",
                    "FreeText20",
                    "FreeDate1",
                    "FreeDate2",
                    "FreeDate3",
                    "FreeDate4",
                    "FreeDate5",
                    "FreeDecimal1",
                    "FreeDecimal2",
                    "FreeDecimal3",
                    "FreeDecimal4",
                    "FreeDecimal5",
                    "FreeDecimal6",
                    "FreeDecimal7",
                    "FreeDecimal8",
                    "FreeDecimal9",
                    "FreeDecimal10",
                    "FreeBit1",
                    "FreeBit2",
                    "FreeBit3",
                    "FreeBit4",
                    "FreeBit5"
                }.ToArray(),
                new List<string>
                {
                    ResourceType,
                    SourceApp,
                    SourceType,
                    ResourceName,
                    DisplayName,
                    Department,
                    ResourceNo,
                    Email,
                    Phone,
                    MobilePhone,
                    ReplacementResource,
                    FieldServiceEmail,
                    PersonalEmail,
                    GpsTrackingResourceNo,
                    HomeAddress,
                    HomeAddressGeoLong.ToString(),
                    HomeAddressGeoLat.ToString(),
                    HomePhone,
                    HomeEmail,
                    HomeRegion,
                    HomePostcode,
                    HomeCity,
                    HomeCount,
                    HomeState,
                    HomeCountry,
                    TeamCode,
                    TeamName,
                    TeamType,
                    TeamSort.ToString(),
                    TeamMemberType,
                    TeamMemberSort.ToString(),
                    DoNotShow,
                    InServiceFrom.ToString(),
                    InServiceTill.ToString(),
                    ExchangeIntegrationEnabled.ToBit().ToString(),
                    url1,
                    urldesc1,
                    url2,
                    urldesc2,
                    url3,
                    urldesc3,
                    BulkPlanning.ToBit().ToString(),
                    BulkCapacity.ToString(),
                    ResourceGpsTrackingEnabled.ToBit().ToString(),
                    Pin,
                    FreeText1,
                    FreeText2,
                    FreeText3,
                    FreeText4,
                    FreeText5,
                    FreeText6,
                    FreeText7,
                    FreeText8,
                    FreeText9,
                    FreeText10,
                    FreeText11,
                    FreeText12,
                    FreeText13,
                    FreeText14,
                    FreeText15,
                    FreeText16,
                    FreeText17,
                    FreeText18,
                    FreeText19,
                    FreeText20,
                    FreeDate1.ToString("s"),
                    FreeDate2.ToString("s"),
                    FreeDate3.ToString("s"),
                    FreeDate4.ToString("s"),
                    FreeDate5.ToString("s"),
                    FreeDecimal1.ToString(),
                    FreeDecimal2.ToString(),
                    FreeDecimal3.ToString(),
                    FreeDecimal4.ToString(),
                    FreeDecimal5.ToString(),
                    FreeDecimal6.ToString(),
                    FreeDecimal7.ToString(),
                    FreeDecimal8.ToString(),
                    FreeDecimal9.ToString(),
                    FreeDecimal10.ToString(),
                    FreeBit1.ToBit().ToString(),
                    FreeBit2.ToBit().ToString(),
                    FreeBit3.ToBit().ToString(),
                    FreeBit4.ToBit().ToString(),
                    FreeBit5.ToBit().ToString(),
                }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException();

        Resource IValidatableImportRequest<Resource>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Resource>(validationContext);
    }
}