using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class FilterValueTests
    {
        private static FilterValue Test => new()
        {
            Group = "Certifications",
            Value = "Forklift level A"
        };

        [Fact]
        public async t.Task FilterValue_Append_ShouldSucceed()
        {
            FilterGroup filterGroup = new() { Name = "Certifications" };
            ImportRequest fgRequest = filterGroup.ToImportRequest(TransactionType.Append);
            ImportRequest fvRequest = Test.ToImportRequest(TransactionType.Append);

            var fgResult = await DimeScheduler.DoImportRequest(fgRequest);
            Assert.True(await DimeScheduler.DoImportRequest(fvRequest));
        }

        [Fact]
        public async t.Task FilterValue_Delete_ShouldSucceed()
        {
            ImportRequest importRequest = Test.ToImportRequest(TransactionType.Delete);
            Assert.True(await DimeScheduler.DoImportRequest(importRequest, TransactionType.Delete));
        }
    }
}