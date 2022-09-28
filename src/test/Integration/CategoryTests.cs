using System.Collections.Generic;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class CategoryTests
    {
        private static Category Test => new()
        {
            Name = "SDK_TEST",
            DisplayName = "SDK Test",
            Color = "#08cd70"
        };

        [Fact]
        public async t.Task Category_Append_ShouldSucceed()
        {
            ImportRequest importRequest = Test.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(importRequest));
        }

        [Fact]
        public async t.Task Category_Delete_ShouldSucceed()
        {
            ImportRequest importRequest = Test.ToImportRequest(TransactionType.Delete);
            Assert.True(await DimeScheduler.DoImportRequest(importRequest, TransactionType.Delete));
        }

        [Fact]
        public async t.Task Category_Append_List_ShouldSucceed()
        {
            Category model1 = new()
            {
                Name = "CATEGORY_1",
                DisplayName = "Category 1",
                Color = "BLUE"
            };

            Category model2 = new()
            {
                Name = "CATEGORY_2",
                DisplayName = "Category 2",
                Color = "BLUE"
            };

            ImportRequest importRequest1 = model1.ToImportRequest(TransactionType.Append);
            ImportRequest importRequest2 = model2.ToImportRequest(TransactionType.Append);

            Assert.True(await DimeScheduler.DoImportRequest(new List<ImportRequest> { importRequest1, importRequest2 }, TransactionType.Append));

        }
    }
}