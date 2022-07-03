﻿using System.Threading.Tasks;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests
{
    public partial class PinsEndpointTests
    {
        [Fact]
        public async Task PinsEndpoint_MockClient_Create_ShouldCreate()
        {
            PinsEndpoint endpoint = new(new MockRestClient<IndicatorRequest>());
            await endpoint.Create(new IndicatorRequest());
        }

        [Fact]
        public async Task PinsEndpoint_MockClient_Update_ShouldUpdate()
        {
            PinsEndpoint endpoint = new(new MockRestClient<IndicatorRequest>());
            await endpoint.Update(new IndicatorRequest());
        }

        [Fact]
        public async Task PinsEndpoint_MockClient_Delete_ShouldDelete()
        {
            PinsEndpoint endpoint = new(new MockRestClient<IndicatorRequest>());
            await endpoint.Delete(new IndicatorRequest());
        }
    }
}