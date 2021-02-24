using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class JobTests
    {
        [Fact]
        public void Job_ToImportRequest_Append_AllShouldMapParameters()
        {
            Job model = new()
            {
                SourceApp = "APP",
                SourceType = "TYPE",
                JobNo = "Job 1",
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
                FreeText9 = "Text"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}