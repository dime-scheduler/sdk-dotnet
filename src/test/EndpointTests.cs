using System;
using System.Net;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class EndpointTests
    {
        [Fact]
        public async System.Threading.Tasks.Task Endpoint_Request_InvalidUrl_WithFormsAuthenticator_ShouldThrowException()
        {
            const string faultyUrl = "https://dimescheduler.io/doesnotexist";
            DimeSchedulerClient client = new(faultyUrl, new FormsAuthenticator(faultyUrl, "user", "password"));

            await Assert.ThrowsAsync<WebException>(async () => await client.Import.Request());
        }

        [Fact]
        public async System.Threading.Tasks.Task Endpoint_Request_InvalidUrl_WithMockAuthenticator_ShouldConstruct()
        {
            const string faultyUrl = "https://dimescheduler.io/doesnotexist";
            DimeSchedulerClient client = new(faultyUrl, new MockAuthenticator());

            IImportEndpoint importEndpoint = await client.Import.Request();
            Assert.NotNull(importEndpoint);
        }
    }
}