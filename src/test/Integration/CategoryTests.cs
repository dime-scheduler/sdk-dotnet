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
    }
}