using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class JobBuilderTests
    {
        [Fact]
        public void JobBuilder_SetMasterData_ShouldMapProperties()
        {
            JobBuilder jobBuilder = new();
            Job job = jobBuilder.WithJob("SOURCEAPP", "SOURCETYPE", "JOBNO", "DESCRIPTION", "SHORTDESCRIPTION",
                "RESPONSIBLE", true).Create();

            Assert.True(job.SourceApp == "SOURCEAPP");
            Assert.True(job.SourceType == "SOURCETYPE");
            Assert.True(job.JobNo == "JOBNO");
            Assert.True(job.Description == "DESCRIPTION");
            Assert.True(job.ShortDescription == "SHORTDESCRIPTION");
            Assert.True(job.Responsible == "RESPONSIBLE");
            Assert.True(job.SentFromBackOffice);
        }

        [Fact]
        public void JobBuilder_SetBill_ShouldMapProperties()
        {
            JobBuilder jobBuilder = new();
            Job job = jobBuilder.WithBill(new Site
            {
                Email = "site1@customer.com",
                Name = "Hotel Berlin",
                No = "HOTEL_BERLIN",
                Phone = "555 123 091",
                Address = new Address { FullAddress = "Kommandantenstraße 18, 10969 Berlin, Germany" }
            }).Create();

            Assert.True(job.BillNo == "HOTEL_BERLIN");
            Assert.True(job.BillName == "Hotel Berlin");
            Assert.True(job.BillEmail == "site1@customer.com");
            Assert.True(job.BillPhone == "555 123 091");
            Assert.True(job.BillAddress == "Kommandantenstraße 18, 10969 Berlin, Germany");
        }

        [Fact]
        public void JobBuilder_SetContact_ShouldMapProperties()
        {
            JobBuilder jobBuilder = new();
            Job job = jobBuilder.WithContact(new Contact
            {
                Address = "Kommandantenstraße 18, 10969 Berlin, Germany",
                Name = "Contact 1",
                No = "CONTACT_001",
                Email = "contact1@customer.com",
                Phone = "555 123 091"
            }).Create();

            Assert.True(job.ContactNo == "CONTACT_001");
            Assert.True(job.ContactName == "Contact 1");
            Assert.True(job.ContactEmail == "contact1@customer.com");
            Assert.True(job.ContactPhone == "555 123 091");
            Assert.True(job.ContactAddress == "Kommandantenstraße 18, 10969 Berlin, Germany");
        }

        [Fact]
        public void JobBuilder_SetCustomer_ShouldMapProperties()
        {
            JobBuilder jobBuilder = new();
            Job job = jobBuilder.WithCustomer(new Sdk.Import.Customer
            {
                Address = "Kommandantenstraße 18, 10969 Berlin, Germany",
                Name = "Customer 1",
                No = "CUSTOMER_001",
                Email = "customer1@customer.com",
                Phone = "555 123 091",
                Reference = "REF"
            }).Create();

            Assert.True(job.CustomerNo == "CUSTOMER_001");
            Assert.True(job.CustomerName == "Customer 1");
            Assert.True(job.CustomerEmail == "customer1@customer.com");
            Assert.True(job.CustomerPhone == "555 123 091");
            Assert.True(job.CustomerAddress == "Kommandantenstraße 18, 10969 Berlin, Germany");
            Assert.True(job.CustomerReference == "REF");
        }

        [Fact]
        public void JobBuilder_SetExtendables_ShouldMapProperties()
        {
            JobBuilder jobBuilder = new();
            Job job = jobBuilder.WithExtendables(new Extendable
            {
                FreeText1 = "Free Text 1",
                FreeText2 = "Free Text 2",
                FreeText3 = "Free Text 3",
                FreeText4 = "Free Text 4",
                FreeText5 = "Free Text 5",
                FreeText6 = "Free Text 6",
                FreeText7 = "Free Text 7",
                FreeText8 = "Free Text 8",
                FreeText9 = "Free Text 9",
                FreeText10 = "Free Text 10",
                FreeText11 = "Free Text 11",
                FreeText12 = "Free Text 12",
                FreeText13 = "Free Text 13",
                FreeText14 = "Free Text 14",
                FreeText15 = "Free Text 15",
                FreeText16 = "Free Text 16",
                FreeText17 = "Free Text 17",
                FreeText18 = "Free Text 18",
                FreeText19 = "Free Text 19",
                FreeText20 = "Free Text 20",
                FreeBit1 = true,
                FreeBit2 = true,
                FreeBit3 = true,
                FreeBit4 = true,
                FreeBit5 = true,
                FreeDecimal1 = 18,
                FreeDecimal2 = 18,
                FreeDecimal3 = 18,
                FreeDecimal4 = 18,
                FreeDecimal5 = 18,
                FreeDate1 = new DateTime(2020, 1, 1),
                FreeDate2 = new DateTime(2020, 1, 1),
                FreeDate3 = new DateTime(2020, 1, 1),
                FreeDate4 = new DateTime(2020, 1, 1),
                FreeDate5 = new DateTime(2020, 1, 1)
            }).Create();
        }

        [Fact]
        public void JobBuilder_SetProject_ShouldMapProperties()
        {
            JobBuilder jobBuilder = new();
            Job job = jobBuilder.WithProject(true, true, true).Create();

            Assert.True(job.AllowDependencies == true);
            Assert.True(job.AvailableInGantt == true);
            Assert.True(job.OverRuleGanttPlanning == true);
        }

        [Fact]
        public void JobBuilder_SetSite_ShouldMapProperties()
        {
            JobBuilder jobBuilder = new();
            Job job = jobBuilder.WithSite(new Site
            {
                Address = new Address
                {
                    FullAddress = "Kommandantenstraße 18, 10969 Berlin, Germany",
                    State = "Brandenburg",
                    City = "Berlin",
                    Region = "EMEA",
                    Street = "Kommandantenstraße",
                    StreetNo = "18",
                    Postcode = "10969",
                    County = "Brandenburg",
                    Country = "Germany"
                },
                Name = "Site 1",
                No = "SITE_001",
                Email = "site1@customer.com",
                Phone = "555 123 091"
            }).Create();

            Assert.True(job.SiteNo == "SITE_001");
            Assert.True(job.SiteName == "Site 1");
            Assert.True(job.SiteEmail == "site1@customer.com");
            Assert.True(job.SitePhone == "555 123 091");
            Assert.True(job.SiteAddress == "Kommandantenstraße 18, 10969 Berlin, Germany");
            Assert.True(job.SiteState == "Brandenburg");
            Assert.True(job.SiteCity == "Berlin");
            Assert.True(job.SiteRegion == "EMEA");
            Assert.True(job.SiteStreet == "Kommandantenstraße");
            Assert.True(job.SiteStreetNo == "18");
            Assert.True(job.SitePostcode == "10969");
            Assert.True(job.SiteCounty == "Brandenburg");
            Assert.True(job.SiteCountry == "Germany");
        }

        [Fact]
        public void JobBuilder_SetSiteFrom_ShouldMapProperties()
        {
            JobBuilder jobBuilder = new();
            Job job = jobBuilder.WithSiteFrom(new Site
            {
                Address = new Address
                {
                    FullAddress = "Kommandantenstraße 18, 10969 Berlin, Germany",
                    State = "Brandenburg",
                    City = "Berlin",
                    Region = "EMEA",
                    Street = "Kommandantenstraße",
                    StreetNo = "18",
                    Postcode = "10969",
                    County = "Brandenburg",
                    Country = "Germany"
                },
                Name = "Site 1",
                No = "SITE_001",
                Email = "site1@customer.com",
                Phone = "555 123 091"
            }).Create();

            Assert.True(job.SiteFromNo == "SITE_001");
            Assert.True(job.SiteFromName == "Site 1");
            Assert.True(job.SiteFromEmail == "site1@customer.com");
            Assert.True(job.SiteFromPhone == "555 123 091");
            Assert.True(job.SiteFromAddress == "Kommandantenstraße 18, 10969 Berlin, Germany");
            Assert.True(job.SiteFromState == "Brandenburg");
            Assert.True(job.SiteFromCity == "Berlin");
            Assert.True(job.SiteFromRegion == "EMEA");
            Assert.True(job.SiteFromStreet == "Kommandantenstraße");
            Assert.True(job.SiteFromStreetNo == "18");
            Assert.True(job.SiteFromPostcode == "10969");
            Assert.True(job.SiteFromCounty == "Brandenburg");
            Assert.True(job.SiteFromCountry == "Germany");
        }
    }
}