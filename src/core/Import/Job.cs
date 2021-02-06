using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class Job : IImportRequestable, IValidatableImportRequest<Job>
    {
        [Required]
        [MaxLength(30)]
        [ImportParameter(nameof(SourceApp), TransactionType.Append, TransactionType.Delete)]
        public string SourceApp { get; set; }

        [Required]
        [MaxLength(10)]
        [ImportParameter(nameof(SourceType), TransactionType.Append, TransactionType.Delete)]
        public string SourceType { get; set; }

        [Required]
        [MaxLength(50)]
        [ImportParameter(nameof(JobNo), TransactionType.Append, TransactionType.Delete)]
        public string JobNo { get; set; }

        [MaxLength(50)]
        [ImportParameter(nameof(ShortDescription), TransactionType.Append)]
        public string ShortDescription { get; set; }

        [RequiredIf(TransactionType.Append)]
        [ImportParameter(nameof(Description), TransactionType.Append)]
        public string Description { get; set; }

        [MaxLength(50)]
        [ImportParameter(nameof(Type), TransactionType.Append)]
        public string Type { get; set; }

        [MaxLength(255)]
        [ImportParameter(nameof(Name), TransactionType.Append)]
        public string Name { get; set; }

        [ImportParameter(nameof(Category), TransactionType.Append)]
        public string Category { get; set; }

        [ImportParameter(nameof(TimeMarker), TransactionType.Append)]
        public string TimeMarker { get; set; }

        [ImportParameter(nameof(Pin), TransactionType.Append)]
        public string Pin { get; set; }

        [ImportParameter(nameof(CustomerNo), TransactionType.Append)]
        public string CustomerNo { get; set; }

        [ImportParameter(nameof(CustomerName), TransactionType.Append)]
        public string CustomerName { get; set; }

        [ImportParameter(nameof(CustomerAddress), TransactionType.Append)]
        public string CustomerAddress { get; set; }

        [ImportParameter(nameof(CustomerAddressGeoLong), TransactionType.Append)]
        public string CustomerAddressGeoLong { get; set; }

        [ImportParameter(nameof(CustomerAddressGeoLat), TransactionType.Append)]
        public string CustomerAddressGeoLat { get; set; }

        [ImportParameter(nameof(CustomerPhone), TransactionType.Append)]
        public string CustomerPhone { get; set; }

        [ImportParameter(nameof(CustomerEmail), TransactionType.Append)]
        public string CustomerEmail { get; set; }

        [ImportParameter(nameof(ContactNo), TransactionType.Append)]
        public string ContactNo { get; set; }

        [ImportParameter(nameof(ContactName), TransactionType.Append)]
        public string ContactName { get; set; }

        [ImportParameter(nameof(ContactAddress), TransactionType.Append)]
        public string ContactAddress { get; set; }

        [ImportParameter(nameof(ContactAddressGeoLong), TransactionType.Append)]
        public string ContactAddressGeoLong { get; set; }

        [ImportParameter(nameof(ContactAddressGeoLat), TransactionType.Append)]
        public string ContactAddressGeoLat { get; set; }

        [ImportParameter(nameof(ContactPhone), TransactionType.Append)]
        public string ContactPhone { get; set; }

        [ImportParameter(nameof(ContactEmail), TransactionType.Append)]
        public string ContactEmail { get; set; }

        [ImportParameter(nameof(SiteNo), TransactionType.Append)]
        public string SiteNo { get; set; }

        [ImportParameter(nameof(SiteName), TransactionType.Append)]
        public string SiteName { get; set; }

        [ImportParameter(nameof(SiteAddress), TransactionType.Append)]
        public string SiteAddress { get; set; }

        [ImportParameter(nameof(SiteAddressGeoLong), TransactionType.Append)]
        public string SiteAddressGeoLong { get; set; }

        [ImportParameter(nameof(SiteAddressGeoLat), TransactionType.Append)]
        public string SiteAddressGeoLat { get; set; }

        [ImportParameter(nameof(SitePhone), TransactionType.Append)]
        public string SitePhone { get; set; }

        [ImportParameter(nameof(SiteEmail), TransactionType.Append)]
        public string SiteEmail { get; set; }

        [ImportParameter(nameof(SiteRegion), TransactionType.Append)]
        public string SiteRegion { get; set; }

        [ImportParameter(nameof(SiteStreet), TransactionType.Append)]
        public string SiteStreet { get; set; }

        [ImportParameter(nameof(SiteStreetNo), TransactionType.Append)]
        public string SiteStreetNo { get; set; }

        [ImportParameter(nameof(SitePostcode), TransactionType.Append)]
        public string SitePostcode { get; set; }

        [ImportParameter(nameof(SiteCity), TransactionType.Append)]
        public string SiteCity { get; set; }

        [ImportParameter(nameof(SiteCounty), TransactionType.Append)]
        public string SiteCounty { get; set; }

        [ImportParameter(nameof(SiteState), TransactionType.Append)]
        public string SiteState { get; set; }

        [ImportParameter(nameof(SiteCountry), TransactionType.Append)]
        public string SiteCountry { get; set; }

        [ImportParameter(nameof(SiteFromNo), TransactionType.Append)]
        public string SiteFromNo { get; set; }

        [ImportParameter(nameof(SiteFromName), TransactionType.Append)]
        public string SiteFromName { get; set; }

        [ImportParameter(nameof(SiteFromAddress), TransactionType.Append)]
        public string SiteFromAddress { get; set; }

        [ImportParameter(nameof(SiteFromAddressGeoLong), TransactionType.Append)]
        public string SiteFromAddressGeoLong { get; set; }

        [ImportParameter(nameof(SiteFromAddressGeoLat), TransactionType.Append)]
        public string SiteFromAddressGeoLat { get; set; }

        [ImportParameter(nameof(SiteFromPhone), TransactionType.Append)]
        public string SiteFromPhone { get; set; }

        [ImportParameter(nameof(SiteFromEmail), TransactionType.Append)]
        public string SiteFromEmail { get; set; }

        [ImportParameter(nameof(SiteFromRegion), TransactionType.Append)]
        public string SiteFromRegion { get; set; }

        [ImportParameter(nameof(SiteFromStreet), TransactionType.Append)]
        public string SiteFromStreet { get; set; }

        [ImportParameter(nameof(SiteFromStreetNo), TransactionType.Append)]
        public string SiteFromStreetNo { get; set; }

        [ImportParameter(nameof(SiteFromPostcode), TransactionType.Append)]
        public string SiteFromPostcode { get; set; }

        [ImportParameter(nameof(SiteFromCity), TransactionType.Append)]
        public string SiteFromCity { get; set; }

        [ImportParameter(nameof(SiteFromCounty), TransactionType.Append)]
        public string SiteFromCounty { get; set; }

        [ImportParameter(nameof(SiteFromState), TransactionType.Append)]
        public string SiteFromState { get; set; }

        [ImportParameter(nameof(SiteFromCountry), TransactionType.Append)]
        public string SiteFromCountry { get; set; }

        [ImportParameter(nameof(BillNo), TransactionType.Append)]
        public string BillNo { get; set; }

        [ImportParameter(nameof(BillName), TransactionType.Append)]
        public string BillName { get; set; }

        [ImportParameter(nameof(BillAddress), TransactionType.Append)]
        public string BillAddress { get; set; }

        [ImportParameter(nameof(BillAddressGeoLong), TransactionType.Append)]
        public string BillAddressGeoLong { get; set; }

        [ImportParameter(nameof(BillAddressGeoLat), TransactionType.Append)]
        public string BillAddressGeoLat { get; set; }

        [ImportParameter(nameof(BillPhone), TransactionType.Append)]
        public string BillPhone { get; set; }

        [ImportParameter(nameof(BillEmail), TransactionType.Append)]
        public string BillEmail { get; set; }

        [ImportParameter(nameof(BillRegion), TransactionType.Append)]
        public string BillRegion { get; set; }

        [ImportParameter(nameof(Importance), TransactionType.Append)]
        public string Importance { get; set; }

        [ImportParameter(nameof(CreationDateTime), TransactionType.Append)]
        public DateTime? CreationDateTime { get; set; }

        [ImportParameter(nameof(CustomerReference), TransactionType.Append)]
        public string CustomerReference { get; set; }

        [ImportParameter(nameof(Language), TransactionType.Append)]
        public string Language { get; set; }

        [ImportParameter(nameof(Responsible), TransactionType.Append)]
        public string Responsible { get; set; }

        [ImportParameter(nameof(Creator), TransactionType.Append)]
        public string Creator { get; set; }

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

        [ImportParameter(nameof(EnableManualSelection), TransactionType.Append)]
        public bool EnableManualSelection { get; set; }

        [ImportParameter(nameof(AvailableInGantt), TransactionType.Append)]
        public bool AvailableInGantt { get; set; }

        [ImportParameter(nameof(StartDate), TransactionType.Append)]
        public DateTime? StartDate { get; set; }

        [ImportParameter(nameof(EndDate), TransactionType.Append)]
        public DateTime? EndDate { get; set; }

        [ImportParameter(nameof(AllowDependencies), TransactionType.Append)]
        public bool AllowDependencies { get; set; }

        [ImportParameter(nameof(Note), TransactionType.Append)]
        public string Note { get; set; }

        [ImportParameter(nameof(OverRuleGanttPlanning), TransactionType.Append)]
        public bool OverRuleGanttPlanning { get; set; }

        [ImportParameter(nameof(CheckAppointments), TransactionType.Delete)]
        public bool CheckAppointments { get; set; }

        [ImportParameter(nameof(SentFromBackOffice), TransactionType.Delete)]
        public bool SentFromBackOffice { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => ((IValidatableImportRequest<Job>)this).Validate(transactionType).CreateAppendRequest(),
                TransactionType.Delete => ((IValidatableImportRequest<Job>)this).Validate(transactionType).CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(ImportProcedures.Job.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(ImportProcedures.Job.Delete, this.CreateParameters(TransactionType.Delete));

        Job IValidatableImportRequest<Job>.Validate(TransactionType transactionType)
            => this.Validate(transactionType);

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            => this.Validate<Job>(validationContext);
    }
}