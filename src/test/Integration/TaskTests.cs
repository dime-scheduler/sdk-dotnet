using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class TaskTests
    {
        internal static Task Test => new()
        {
            SourceApp = "POWERAPPS",
            SourceType = "POWERAPPS",
            JobNo = "POWERAPP_001",
            TaskNo = "SDK_TEST_001",
            Category = "OFFICE",
            TimeMarker = "Busy",
            Importance = Importance.High,
            Description = "Plan a task from the SDK",
            AppointmentEarliestAllowed = DateTime.Now.AddDays(-5),
            AppointmentLatestAllowed = DateTime.Now.AddDays(35),
            ContractDescription = "DESC",
            ContractEndDate = new DateTime(2020, 1, 1),
            ContractNo = "NO",
            ContractStartDate = new DateTime(2020, 1, 1),
            ContractType = "TYPE",
            DeadLine = new DateTime(2020, 1, 1, 15, 30, 15),
            DoNotCountAppointmentResource = true,
            ExpectedResponseDateTime = DateTime.Now.AddDays(2),
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
            IrisArea = "AREA",
            IrisFault = "FAULT",
            IrisReason = "REASON",
            IrisResolution = "RESOLUTION",
            IrisSymptom = "SYMPTON",
            IgnoreCalendars = true,
            Index = 1,
            InfiniteTask = true,
            LaborWarrantyEndDate = new DateTime(2020, 1, 1),
            LaborWarrantyStartDate = new DateTime(2020, 1, 1),
            LocationDescription = "DESC",
            PartsWarrantyEndDate = new DateTime(2020, 1, 1),
            PartsWarrantyStartDate = new DateTime(2020, 1, 1),
            PlanningQty = 500.21M,
            PlanningUOM = "UOM",
            PlanningUOMConversion = 25,
            RequiredNoResources = 1,
            RequiredTotalDurationInSeconds = 18000,
            RoundToUOM = true,
            ServiceClass = "CLASS",
            ServiceGroup = "GROUP",
            ServiceName = "NAME",
            ServiceNo = "NO",
            ServiceSerialNo = "SERIAL",
            ShortDescription = "Task from SDK test suite.",
            TaskType = TaskType.Planning,
            Url1 = "URL",
            Url2 = "URL",
            Url3 = "URL",
            UrlDescription1 = "URL DESC",
            UrlDescription2 = "URL DESC",
            UrlDescription3 = "URL DESC",
            UseFixPlanningQty = true
        };

        [Fact]
        public async t.Task Task_Append_ShouldSucceed()
        {
            ImportRequest importRequest = Test.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(importRequest));
        }

        [Fact]
        public async t.Task Task_Delete_ShouldSucceed()
        {
            ImportRequest importRequest = Test.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(importRequest));
        }
    }
}