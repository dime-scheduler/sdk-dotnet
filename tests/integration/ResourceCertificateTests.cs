using System;
using Dime.Scheduler.Entities;
using Dime.Scheduler.IntegrationTests.Retry;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceCertificateTests : IClassFixture<DimeSchedulerClientFixture>
    {
        private readonly DimeSchedulerClientFixture _dimeSchedulerClientFixture;

        public ResourceCertificateTests(DimeSchedulerClientFixture dimeSchedulerClientFixture)
        {
            _dimeSchedulerClientFixture = dimeSchedulerClientFixture;
        }

        [SkippableFact]
        public async System.Threading.Tasks.Task ResourceCertificate_ToImportRequest_Append_AllShouldMapParameters()
        {
            Skip.If(_dimeSchedulerClientFixture.Client == null);

            ResourceCertificate model = new()
            {
                ResourceNo = EntityNos.Resource,
                LastScoreDate = new DateTime(2020, 1, 1),
                No = "NO",
                Score = "SCORE",
                ValidUntil = new DateTime(2020, 1, 2)
            };

            Result response = await TooManyRequestRetryPolicy.ExecuteAsync(async () => await _dimeSchedulerClientFixture.Client.Resources.CreateAsync(model));
            Assert.True(response.IsSuccess, response.Error?.ToString());
        }
    }
}