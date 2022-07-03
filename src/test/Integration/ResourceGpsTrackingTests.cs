using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class ResourceGpsTrackingTests
    {
        [Fact]
        public async t.Task ResourceGpsTracking_Append_AllShouldMapParameters()
        {
            // Set location to a place near Los Angeles
            ResourceGpsTracking model = new()
            {
                ResourceNo = "Hendrik (Mobile)",
                Latitude = 34.210446M,
                Longitude = -118.436528M
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(importRequest));
        }
    }
}