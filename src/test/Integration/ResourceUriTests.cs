using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class ResourceUriTests
    {
        [Fact]
        public async t.Task ResourceUri_Append_ShouldCreateAppointment()
        {
            // Ensure resource exists
            ImportRequest resourceBaseRequest = ResourceTests.Test.ToImportRequest(TransactionType.Append);
            await DimeScheduler.DoImportRequest(resourceBaseRequest);

            ResourceUri resourceUri = new()
            {
                ResourceNo = ResourceTests.Test.ResourceNo,
                Uri = "http://www.google.com",
                Description = "Send message to resource"
            };

            ImportRequest resourceUriRequest = resourceUri.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(resourceUriRequest));
        }
    }
}