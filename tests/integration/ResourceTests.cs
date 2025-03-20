using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public ResourceTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [Fact]
        public async System.Threading.Tasks.Task Resource()
        {
            Resource model = new()
            {
                ResourceNo = EntityNos.Resource,
                GpsTrackingResourceNo = "1",
                BulkCapacity = 1,
                BulkPlanning = true,
                Department = "TEXT",
                DisplayName = "TEXT",
                DoNotShow = false,
                Email = "TEXT",
                ExchangeIntegrationEnabled = true,
                FieldServiceEmail = "TEXT",
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
                FreeText1 = "TEXT",
                FreeText10 = "TEXT",
                FreeText11 = "TEXT",
                FreeText12 = "TEXT",
                FreeText13 = "TEXT",
                FreeText14 = "TEXT",
                FreeText15 = "TEXT",
                FreeText16 = "TEXT",
                FreeText17 = "TEXT",
                FreeText18 = "TEXT",
                FreeText19 = "TEXT",
                FreeText2 = "TEXT",
                FreeText20 = "TEXT",
                FreeText3 = "TEXT",
                FreeText4 = "TEXT",
                FreeText5 = "TEXT",
                FreeText6 = "TEXT",
                FreeText7 = "TEXT",
                FreeText8 = "TEXT",
                FreeText9 = "TEXT",
                HomeAddress = "TEXT",
                HomeAddressGeoLat = 1,
                HomeAddressGeoLong = 2,
                HomeCity = "TEXT",
                HomeCountry = "TEXT",
                HomeCounty = "TEXT",
                HomeEmail = "TEXT",
                HomeStreet = "TEXT",
                HomeStreetNo = "5",
                HomePhone = "TEXT",
                HomePostcode = "TEXT",
                HomeRegion = "TEXT",
                HomeState = "TEXT",
                InServiceFrom = new DateTime(2020, 1, 1),
                InServiceTill = new DateTime(2020, 1, 1),
                MobilePhone = "TEXT",
                PersonalEmail = "TEXT",
                Phone = "TEXT",
                Pin = "TEXT",
                ReplacementResource = false,
                ResourceGpsTrackingEnabled = true,
                ResourceName = "TEXT",
                ResourceType = "TEXT",
                ResourceTypeId = 1,
                SourceApp = "TEXT",
                SourceType = "TEXT",
                Url1 = "TEXT",
                UrlDescription1 = "TEXT",
                Url2 = "TEXT",
                UrlDescription2 = "TEXT",
                Url3 = "TEXT",
                UrlDescription3 = "TEXT",
                TeamCode = "TEXT",
                TeamMemberSort = 1,
                TeamMemberType = "TEXT",
                TeamName = "TEXT",
                TeamSort = 1,
                TeamType = "TEXT"
            };

            Result response = await _dimeSchedulerClientFixture.Client.Resources.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}