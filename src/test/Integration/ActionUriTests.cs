using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class ActionUriTests
    {
        [Fact]
        public async t.Task ActionUri_Append_ShouldSucceed()
        {
            ActionUri model = new()
            {
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                UriType = UriType.PlanningBoard,
                Uri = "https://www.google.com",
                Description = "Confirm appointment",
                Default = true
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(importRequest));
        }
    }
}