using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class ResourceTests
    {
        internal static Dime.Scheduler.Sdk.Import.Resource Test => new()
        {
            ResourceNo = "SDK_TEST",
            GpsTrackingResourceNo = "1",
            BulkCapacity = 1,
            BulkPlanning = true,
            Department = "QA",
            DisplayName = "SDK Test",
            DoNotShow = false,
            Email = "hendrik@dimescheduler.com",
            ExchangeIntegrationEnabled = true,
            FieldServiceEmail = "hendrik@dime-software.com",
            FreeBit1 = true,
            FreeBit2 = false,
            FreeBit3 = true,
            FreeBit4 = false,
            FreeBit5 = true,
            FreeDate1 = new DateTime(2022, 1, 1),
            FreeDate2 = new DateTime(2022, 2, 2),
            FreeDate3 = new DateTime(2022, 3, 3),
            FreeDate4 = new DateTime(2022, 4, 4),
            FreeDate5 = new DateTime(2022, 5, 5),
            FreeDecimal1 = 1,
            FreeDecimal2 = 2,
            FreeDecimal3 = 3,
            FreeDecimal4 = 4,
            FreeDecimal5 = 5,
            FreeText1 = "TEXT 1",
            FreeText10 = "TEXT 10",
            FreeText11 = "TEXT 11",
            FreeText12 = "TEXT 12",
            FreeText13 = "TEXT 13",
            FreeText14 = "TEXT 14",
            FreeText15 = "TEXT 15",
            FreeText16 = "TEXT 16",
            FreeText17 = "TEXT 17",
            FreeText18 = "TEXT 18",
            FreeText19 = "TEXT 19",
            FreeText2 = "TEXT 2",
            FreeText20 = "TEXT 20",
            FreeText3 = "TEXT 3",
            FreeText4 = "TEXT 4",
            FreeText5 = "TEXT 5",
            FreeText6 = "TEXT 6",
            FreeText7 = "TEXT 7",
            FreeText8 = "TEXT 8",
            FreeText9 = "TEXT 9",
            HomeEmail = "hendrik@dimescheduler.com",
            HomePhone = "+52 444 55 66",
            HomeCity = "Paliano",
            HomeCountry = "Italy",
            HomeCounty = "Frosinone",
            HomeStreet = "Corso Garibaldi",
            HomeStreetNo = "95",
            HomePostcode = "03018",
            InServiceFrom = new DateTime(2020, 1, 1),
            InServiceTill = new DateTime(2020, 1, 1),
            MobilePhone = "+52 444 555 666",
            PersonalEmail = "hendrik@dime-software.com",
            Phone = "+52 444 555 666",
            Pin = "Truck",
            ReplacementResource = false,
            ResourceGpsTrackingEnabled = true,
            ResourceName = "TEXT",
            SourceApp = "SDK",
            SourceType = "SDK",
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

        [Fact]
        public async t.Task Resource_Append_ShouldSucceed()
        {            
            ImportRequest importRequest = Test.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(importRequest));
        }
    }
}