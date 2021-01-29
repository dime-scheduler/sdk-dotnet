using System;
using System.Collections.Generic;

namespace Dime.Scheduler.Sdk
{
    public class JobImportRequest : IImportRequestable
    {
        public string SourceApp { get; set; }
        public string SourceType { get; set; }
        public string JobNo { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string TimeMarker { get; set; }
        public string Pin { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerAddressGeoLong { get; set; }
        public string CustomerAddressGeoLat { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string ContactNo { get; set; }
        public string ContactName { get; set; }
        public string ContactAddress { get; set; }
        public string ContactAddressGeoLong { get; set; }
        public string ContactAddressGeoLat { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string SiteNo { get; set; }
        public string SiteName { get; set; }
        public string SiteAddress { get; set; }
        public string SiteAddressGeoLong { get; set; }
        public string SiteAddressGeoLat { get; set; }
        public string SitePhone { get; set; }
        public string SiteEmail { get; set; }
        public string SiteRegion { get; set; }
        public string SiteStreet { get; set; }
        public string SiteStreetNo { get; set; }
        public string SitePostcode { get; set; }
        public string SiteCity { get; set; }
        public string SiteCounty { get; set; }
        public string SiteState { get; set; }
        public string SiteCountry { get; set; }
        public string SiteFromNo { get; set; }
        public string SiteFromName { get; set; }
        public string SiteFromAddress { get; set; }
        public string SiteFromAddressGeoLong { get; set; }
        public string SiteFromAddressGeoLat { get; set; }
        public string SiteFromPhone { get; set; }
        public string SiteFromEmail { get; set; }
        public string SiteFromRegion { get; set; }
        public string SiteFromStreet { get; set; }
        public string SiteFromStreetNo { get; set; }
        public string SiteFromPostcode { get; set; }
        public string SiteFromCity { get; set; }
        public string SiteFromCounty { get; set; }
        public string SiteFromState { get; set; }
        public string SiteFromCountry { get; set; }
        public string BillNo { get; set; }
        public string BillName { get; set; }
        public string BillAddress { get; set; }
        public string BillAddressGeoLong { get; set; }
        public string BillAddressGeoLat { get; set; }
        public string BillPhone { get; set; }
        public string BillEmail { get; set; }
        public string BillRegion { get; set; }
        public string Importance { get; set; }
        public string Creation { get; set; }
        public string CustomerReference { get; set; }
        public string Language { get; set; }
        public string Responsible { get; set; }
        public string Creator { get; set; }
        public string FreeText1 { get; set; }
        public string FreeText2 { get; set; }
        public string FreeText3 { get; set; }
        public string FreeText4 { get; set; }
        public string FreeText5 { get; set; }
        public string FreeText6 { get; set; }
        public string FreeText7 { get; set; }
        public string FreeText8 { get; set; }
        public string FreeText9 { get; set; }
        public string FreeText { get; set; }
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
        public decimal FreeDecimal1 { get; set; }
        public decimal FreeDecimal2 { get; set; }
        public decimal FreeDecimal3 { get; set; }
        public decimal FreeDecimal4 { get; set; }
        public decimal FreeDecimal5 { get; set; }
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
        public bool EnableManualSelection { get; set; }
        public bool AvailableInGantt { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool AllowDependencies { get; set; }
        public string Note { get; set; }
        public bool OverRuleGanttPlanning { get; set; }

        public ImportRequest ToImportRequest()
        => new ImportRequest(
            "mboc_upsertJob",
            new List<string>
            {
                "SourceApp",
                "SourceType",
                "JobNo",
                "ShortDescription",
                "Description",
                "Type",
                "Name",
                "Category",
                "TimeMarker",
                "Pin",
                "CustomerNo",
                "CustomerName",
                "CustomerAddress",
                "CustomerAddressGeoLong",
                "CustomerAddressGeoLat",
                "CustomerPhone",
                "CustomerEmail",
                "ContactNo",
                "ContactName",
                "ContactAddress",
                "ContactAddressGeoLong",
                "ContactAddressGeoLat",
                "ContactPhone",
                "ContactEmail",
                "SiteNo",
                "SiteName",
                "SiteAddress",
                "SiteAddressGeoLong",
                "SiteAddressGeoLat",
                "SitePhone",
                "SiteEmail",
                "SiteRegion",
                "SiteStreet",
                "SiteStreetNo",
                "SitePostcode",
                "SiteCity",
                "SiteCounty",
                "SiteState",
                "SiteCountry",
                "SiteFromNo",
                "SiteFromName",
                "SiteFromAddress",
                "SiteFromAddressGeoLong",
                "SiteFromAddressGeoLat",
                "SiteFromPhone",
                "SiteFromEmail",
                "SiteFromRegion",
                "SiteFromStreet",
                "SiteFromStreetNo",
                "SiteFromPostcode",
                "SiteFromCity",
                "SiteFromCounty",
                "SiteFromState",
                "SiteFromCountry",
                "BillNo",
                "BillName",
                "BillAddress",
                "BillAddressGeoLong",
                "BillAddressGeoLat",
                "BillPhone",
                "BillEmail",
                "BillRegion",
                "Importance",
                "Creation",
                "CustomerReference",
                "Language",
                "Responsible",
                "Creator",
                "FreeText1",
                "FreeText2",
                "FreeText3",
                "FreeText4",
                "FreeText5",
                "FreeText6",
                "FreeText7",
                "FreeText8",
                "FreeText9",
                "FreeText",
                "FreeText11",
                "FreeText12",
                "FreeText13",
                "FreeText14",
                "FreeText15",
                "FreeText16",
                "FreeText17",
                "FreeText18",
                "FreeText19",
                "FreeText2",
                "FreeDecimal1",
                "FreeDecimal2",
                "FreeDecimal3",
                "FreeDecimal4",
                "FreeDecimal5",
                "FreeDate1",
                "FreeDate2",
                "FreeDate3",
                "FreeDate4",
                "FreeDate5",
                "FreeBit1",
                "FreeBit2",
                "FreeBit3",
                "FreeBit4",
                "FreeBit5",
                "EnableManualSelection",
                "AvailableInGantt",
                "StartDate",
                "EndDate",
                "AllowDependencies",
                "Note",
                "OverRuleGanttPlanning",
            }.ToArray(),
            new List<string>
            {
                SourceApp,
                SourceType,
                JobNo,
                ShortDescription,
                Description,
                Type,
                Name,
                Category,
                TimeMarker,
                Pin,
                CustomerNo,
                CustomerName,
                CustomerAddress,
                CustomerAddressGeoLong,
                CustomerAddressGeoLat,
                CustomerPhone,
                CustomerEmail,
                ContactNo,
                ContactName,
                ContactAddress,
                ContactAddressGeoLong,
                ContactAddressGeoLat,
                ContactPhone,
                ContactEmail,
                SiteNo,
                SiteName,
                SiteAddress,
                SiteAddressGeoLong,
                SiteAddressGeoLat,
                SitePhone,
                SiteEmail,
                SiteRegion,
                SiteStreet,
                SiteStreetNo,
                SitePostcode,
                SiteCity,
                SiteCounty,
                SiteState,
                SiteCountry,
                SiteFromNo,
                SiteFromName,
                SiteFromAddress,
                SiteFromAddressGeoLong,
                SiteFromAddressGeoLat,
                SiteFromPhone,
                SiteFromEmail,
                SiteFromRegion,
                SiteFromStreet,
                SiteFromStreetNo,
                SiteFromPostcode,
                SiteFromCity,
                SiteFromCounty,
                SiteFromState,
                SiteFromCountry,
                BillNo,
                BillName,
                BillAddress,
                BillAddressGeoLong,
                BillAddressGeoLat,
                BillPhone,
                BillEmail,
                BillRegion,
                Importance,
                Creation,
                CustomerReference,
                Language,
                Responsible,
                Creator,
                FreeText1,
                FreeText2,
                FreeText3,
                FreeText4,
                FreeText5,
                FreeText6,
                FreeText7,
                FreeText8,
                FreeText9,
                FreeText,
                FreeText11,
                FreeText12,
                FreeText13,
                FreeText14,
                FreeText15,
                FreeText16,
                FreeText17,
                FreeText18,
                FreeText19,
                FreeText2,
                FreeDecimal1.ToString(),
                FreeDecimal2.ToString(),
                FreeDecimal3.ToString(),
                FreeDecimal4.ToString(),
                FreeDecimal5.ToString(),
                FreeDate1?.ToString("s"),
                FreeDate2?.ToString("s"),
                FreeDate3?.ToString("s"),
                FreeDate4?.ToString("s"),
                FreeDate5?.ToString("s"),
                FreeBit1.ToString(),
                FreeBit2.ToString(),
                FreeBit3.ToString(),
                FreeBit4.ToString(),
                FreeBit5.ToString(),
                EnableManualSelection.ToString(),
                AvailableInGantt.ToString(),
                StartDate,
                EndDate,
                AllowDependencies.ToString(),
                Note,
                OverRuleGanttPlanning.ToString()
            }.ToArray());
    }
}