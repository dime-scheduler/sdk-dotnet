﻿using System;
using Dime.Scheduler.Entities;
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

        [Fact]
        public async System.Threading.Tasks.Task ResourceCertificate_ToImportRequest_Append_AllShouldMapParameters()
        {
            ResourceCertificate model = new()
            {
                ResourceNo = EntityNos.Resource,
                LastScoreDate = new DateTime(2020, 1, 1),
                No = "NO",
                Score = "SCORE",
                ValidUntil = new DateTime(2020, 1, 2)
            };

            Result response = await _dimeSchedulerClientFixture.Client.Resources.CreateAsync(model);
            Assert.True(response.IsSuccess, response.Error);
        }
    }
}