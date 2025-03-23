using System;
using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class JobTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public JobTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task Job()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            Job model = new()
            {
                SourceApp = EntityNos.SourceApp,
                SourceType = EntityNos.SourceType,
                JobNo = EntityNos.Job,
                SentFromBackOffice = true,
                Importance = Importance.Medium,
                Description = "DESC",
                Name = "Name",
                Category = "CAT",
                TimeMarker = "TM",
                StartDate = new DateTime(2020, 1, 1),
                Type = "1",
                EndDate = new DateTime(2020, 1, 2),
                AllowDependencies = true,
                AvailableInGantt = true,
                BillAddress = "BILL",
                BillEmail = "BILL",
                BillName = "BILL",
                BillNo = "BILL",
                BillPhone = "BILL",
                BillRegion = "BILL",
                CheckAppointments = true,
                ContactAddress = "CONTACT",
                ContactEmail = "CONTACT",
                ContactName = "CONTACT",
                ContactNo = "CONTACT",
                ContactPhone = "CONTACT",
                CreationDateTime = new DateTime(2020, 1, 1),
                Creator = "Jesus' dad",
                CustomerAddress = "CUSTOMER",
                CustomerEmail = "CUSTOMER",
                CustomerName = "CUSTOMER",
                CustomerNo = "CUSTOMER",
                CustomerPhone = "CUSTOMER",
                CustomerReference = "CUSTOMER",
                EnableManualSelection = true,
                FreeBit1 = true,
                FreeBit2 = true,
                FreeBit3 = true,
                FreeBit4 = true,
                FreeBit5 = true,
                FreeDate1 = new DateTime(2020, 1, 1),
                FreeDate2 = new DateTime(2020, 1, 1),
                FreeDate3 = new DateTime(2020, 1, 1),
                FreeDate4 = new DateTime(2020, 1, 1),
                FreeDate5 = new DateTime(2020, 1, 1),
                FreeDecimal1 = 1,
                FreeDecimal2 = 2,
                FreeDecimal3 = 3,
                FreeDecimal4 = 4,
                FreeDecimal5 = 5,
                FreeText1 = "Text",
                FreeText10 = "Text",
                FreeText11 = "Text",
                FreeText12 = "Text",
                FreeText13 = "Text",
                FreeText14 = "Text",
                FreeText15 = "Text",
                FreeText16 = "Text",
                FreeText17 = "Text",
                FreeText18 = "Text",
                FreeText19 = "Text",
                FreeText2 = "Text",
                FreeText20 = "Text",
                FreeText3 = "Text",
                FreeText4 = "Text",
                FreeText5 = "Text",
                FreeText6 = "Text",
                FreeText7 = "Text",
                FreeText8 = "Text",
                FreeText9 = "Text",
                Language = "EN",
                Note = "NOTE",
                OverRuleGanttPlanning = true,
                Pin = "PIN",
                Responsible = "YES",
                ShortDescription = "DESC",
                SiteAddress = "SITE",
                SiteCity = "SITE",
                SiteCountry = "SITE",
                SiteCounty = "SITE",
                SiteEmail = "SITE",
                SiteFromAddress = "SITE",
                SiteFromCity = "SITE",
                SiteFromCountry = "SITE",
                SiteFromCounty = "SITE",
                SiteFromEmail = "SITE",
                SiteFromName = "SITE",
                SiteFromNo = "SITE",
                SiteFromPhone = "SITE",
                SiteFromPostcode = "SITE",
                SiteFromRegion = "SITE",
                SiteFromState = "SITE",
                SiteFromStreet = "SITE",
                SiteFromStreetNo = "SITE",
                SiteName = "SITE",
                SiteNo = "SITE",
                SitePhone = "SITE",
                SitePostcode = "SITE",
                SiteRegion = "SITE",
                SiteState = "SITE",
                SiteStreet = "SITE",
                SiteStreetNo = "SITE"
            };

            Result response = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Jobs.CreateAsync(model));
            Assert.True(response.IsSuccess, response.Error?.ToString());
        }
    }
}