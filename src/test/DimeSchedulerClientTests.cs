﻿using System.Threading.Tasks;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests
{
    public partial class DimeSchedulerClientTests
    {
        [Fact]
        public void DimeSchedulerClient_Constructor_ShouldCreate()
        {
            const string uri = "http://mydimescheduler.io";
            IAuthenticator authenticator = new MockAuthenticator();
            DimeSchedulerClient client = new(uri, authenticator);

            Assert.NotNull(client);
        }

        [Fact]
        public async Task DimeSchedulerClient_ImportEndpoint_ShouldCreate()
        {
            const string uri = "http://mydimescheduler.io";
            IAuthenticator authenticator = new MockAuthenticator();
            DimeSchedulerClient client = new(uri, authenticator);

            IImportEndpoint endpoint = await client.Import.Request();
            Assert.NotNull(endpoint);
        }

        [Fact]
        public async Task DimeSchedulerClient_MessageEndpoint_ShouldCreate()
        {
            const string uri = "http://mydimescheduler.io";
            IAuthenticator authenticator = new MockAuthenticator();
            DimeSchedulerClient client = new(uri, authenticator);

            IMessageEndpoint endpoint = await client.Messages.Request();
            Assert.NotNull(endpoint);
        }

        [Fact]
        public async Task DimeSchedulerClient_LicenseEndpoint_ShouldCreate()
        {
            const string uri = "http://mydimescheduler.io";
            IAuthenticator authenticator = new MockAuthenticator();
            DimeSchedulerClient client = new(uri, authenticator);

            ILicenseEndpoint endpoint = await client.License.Request();
            Assert.NotNull(endpoint);
        }
    }
}