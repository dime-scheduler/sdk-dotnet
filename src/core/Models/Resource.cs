using System;
using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Sdk
{
    [ExcludeFromCodeCoverage]
    public class Resource
    {
        public string SourceApp { get; set; }

        public string SourceType { get; set; }

        public string DisplayName { get; set; }

        public string Department { get; set; }

        public string ResourceNo { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string MobilePhone { get; set; }

        public bool ReplacementResource { get; set; }

        public string FieldServiceEmail { get; set; }

        public string PersonalEmail { get; set; }

        public string GpsTrackingResourceNo { get; set; }

        public string HomeAddress { get; set; }

        public double? HomeAddressGeoLong { get; set; }

        public double? HomeAddressGeoLat { get; set; }

        public string HomePhone { get; set; }

        public string HomeEmail { get; set; }

        public string HomeStreet { get; set; }

        public string HomeStreetNo { get; set; }

        public string HomeRegion { get; set; }

        public string HomePostcode { get; set; }

        public string HomeCity { get; set; }

        public string HomeCounty { get; set; }

        public string HomeState { get; set; }

        public string HomeCountry { get; set; }

        public string TeamCode { get; set; }

        public string TeamName { get; set; }

        public string TeamType { get; set; }

        public int? TeamSort { get; set; }

        public string TeamMemberType { get; set; }

        public int? TeamMemberSort { get; set; }

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

        public decimal? FreeDecimal1 { get; set; }

        public decimal? FreeDecimal2 { get; set; }

        public decimal? FreeDecimal3 { get; set; }

        public decimal? FreeDecimal4 { get; set; }

        public decimal? FreeDecimal5 { get; set; }

        public decimal? FreeDecimal6 { get; set; }

        public decimal? FreeDecimal7 { get; set; }

        public decimal? FreeDecimal8 { get; set; }

        public decimal? FreeDecimal9 { get; set; }

        public decimal? FreeDecimal10 { get; set; }

        public DateTime? FreeDate1 { get; set; }

        public DateTime? FreeDate2 { get; set; }

        public DateTime? FreeDate3 { get; set; }

        public DateTime? FreeDate4 { get; set; }

        public DateTime? FreeDate5 { get; set; }

        public bool FreeBit1 { get; set; }

        public bool FreeBit2 { get; set; }

        public bool FreeBit3 { get; set; }

        public bool FreeBit4 { get; set; }

        public bool FreeBit5 { get; set; }

        public bool DoNotShow { get; set; }

        public DateTime? InServiceFrom { get; set; }

        public DateTime? InServiceTill { get; set; }

        public bool ExchangeIntegrationEnabled { get; set; }

        public bool GpsTrackingEnabled { get; set; }

        public bool BulkPlanning { get; set; }

        public decimal? BulkCapacity { get; set; }
    }
}