using System;

namespace Dime.Scheduler.Sdk.Import.Builder
{
    [Obsolete("Will be removed in version 2.x")]
    public class JobBuilder : IImportRequestableBuilder<Job>
    {
        private readonly Job _job = new();

        public JobBuilder WithJob(string sourceApp, string sourceType, string jobNo, string description, string shortDescription, string responsible, bool sentFromBackOffice = false)
        {
            _job.JobNo = jobNo;
            _job.SourceApp = sourceApp;
            _job.SourceType = sourceType;
            _job.Description = description;
            _job.ShortDescription = shortDescription;
            _job.Responsible = responsible;
            _job.SentFromBackOffice = sentFromBackOffice;

            return this;
        }

        public JobBuilder WithCustomer(Customer customer)
        {
            _job.CustomerNo = customer.No;
            _job.CustomerName = customer.Name;
            _job.CustomerEmail = customer.Email;
            _job.CustomerPhone = customer.Phone;
            _job.CustomerReference = customer.Reference;
            _job.CustomerAddress = customer.Address;

            return this;
        }

        public JobBuilder WithContact(Contact contact)
        {
            _job.ContactNo = contact.No;
            _job.ContactName = contact.Name;
            _job.ContactEmail = contact.Email;
            _job.ContactPhone = contact.Phone;
            _job.ContactAddress = contact.Address;

            return this;
        }

        public JobBuilder WithExtendables(Extendable extendable)
            => WithFreeTextExtendables(extendable)
                .WithFreeDateExtendables(extendable)
                .WithFreeDecimalExtendables(extendable)
                .WithFreeBooleanExtendables(extendable);

        private JobBuilder WithFreeTextExtendables(Extendable extendable)
        {
            _job.FreeText1 = extendable.FreeText1;
            _job.FreeText2 = extendable.FreeText2;
            _job.FreeText3 = extendable.FreeText3;
            _job.FreeText4 = extendable.FreeText4;
            _job.FreeText5 = extendable.FreeText5;
            _job.FreeText6 = extendable.FreeText6;
            _job.FreeText7 = extendable.FreeText7;
            _job.FreeText8 = extendable.FreeText8;
            _job.FreeText9 = extendable.FreeText9;
            _job.FreeText10 = extendable.FreeText10;
            _job.FreeText11 = extendable.FreeText11;
            _job.FreeText12 = extendable.FreeText12;
            _job.FreeText13 = extendable.FreeText13;
            _job.FreeText14 = extendable.FreeText14;
            _job.FreeText15 = extendable.FreeText15;
            _job.FreeText16 = extendable.FreeText16;
            _job.FreeText17 = extendable.FreeText17;
            _job.FreeText18 = extendable.FreeText18;
            _job.FreeText19 = extendable.FreeText19;
            _job.FreeText20 = extendable.FreeText20;

            return this;
        }

        private JobBuilder WithFreeDecimalExtendables(Extendable extendable)
        {

            _job.FreeDecimal1 = extendable.FreeDecimal1;
            _job.FreeDecimal2 = extendable.FreeDecimal2;
            _job.FreeDecimal3 = extendable.FreeDecimal3;
            _job.FreeDecimal4 = extendable.FreeDecimal4;
            _job.FreeDecimal5 = extendable.FreeDecimal5;

            return this;
        }

        private JobBuilder WithFreeDateExtendables(Extendable extendable)
        {
            _job.FreeDate1 = extendable.FreeDate1;
            _job.FreeDate2 = extendable.FreeDate2;
            _job.FreeDate3 = extendable.FreeDate3;
            _job.FreeDate4 = extendable.FreeDate4;
            _job.FreeDate5 = extendable.FreeDate5;

            return this;
        }

        private JobBuilder WithFreeBooleanExtendables(Extendable extendable)
        {
            _job.FreeBit1 = extendable.FreeBit1;
            _job.FreeBit2 = extendable.FreeBit2;
            _job.FreeBit3 = extendable.FreeBit3;
            _job.FreeBit4 = extendable.FreeBit4;
            _job.FreeBit5 = extendable.FreeBit5;

            return this;
        }

        public JobBuilder WithSite(Site site)
        {
            _job.SiteNo = site.No;
            _job.SiteName = site.Name;
            _job.SiteEmail = site.Email;
            _job.SitePhone = site.Phone;
            _job.SiteStreet = site.Address.Street;
            _job.SiteStreetNo = site.Address.StreetNo;
            _job.SiteCity = site.Address.City;
            _job.SitePostcode = site.Address.Postcode;
            _job.SiteCounty = site.Address.County;
            _job.SiteState = site.Address.State;
            _job.SiteCountry = site.Address.Country;
            _job.SiteAddress = site.Address.FullAddress;
            _job.SiteRegion = site.Address.Region;

            return this;
        }

        public JobBuilder WithSiteFrom(Site site)
        {
            _job.SiteFromNo = site.No;
            _job.SiteFromName = site.Name;
            _job.SiteFromEmail = site.Email;
            _job.SiteFromPhone = site.Phone;
            _job.SiteFromStreet = site.Address.Street;
            _job.SiteFromStreetNo = site.Address.StreetNo;
            _job.SiteFromCity = site.Address.City;
            _job.SiteFromPostcode = site.Address.Postcode;
            _job.SiteFromCounty = site.Address.County;
            _job.SiteFromState = site.Address.State;
            _job.SiteFromCountry = site.Address.Country;
            _job.SiteFromAddress = site.Address.FullAddress;
            _job.SiteFromRegion = site.Address.Region;

            return this;
        }

        public JobBuilder WithBill(Site bill)
        {
            _job.BillNo = bill.No;
            _job.BillName = bill.Name;
            _job.BillEmail = bill.Email;
            _job.BillPhone = bill.Phone;
            _job.BillRegion = bill.Address.Region;
            _job.BillAddress = bill.Address.FullAddress;

            return this;
        }

        public JobBuilder WithProject(bool allowDependencies = false, bool availableInGantt = false, bool overRuleGanttPlanning = false)
        {
            _job.AllowDependencies = allowDependencies;
            _job.AvailableInGantt = availableInGantt;
            _job.OverRuleGanttPlanning = overRuleGanttPlanning;

            return this;
        }

        public Job Create() => _job;
    }
}