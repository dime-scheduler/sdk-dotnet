using System;
using DotNetEnv;

namespace Dime.Scheduler.IntegrationTests
{
    public class DimeSchedulerClientFixture : IDisposable
    {
        public DimeSchedulerClientFixture()
        {
            Env.Load(".env.development");
            string? key = Env.GetString("APIKEY");
            Client = new(key, "https://test.api.dimescheduler.com");
        }

        public void Dispose()
        {
        }

        public DimeSchedulerClient Client { get; private set; }
    }
}