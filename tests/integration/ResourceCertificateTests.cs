using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceCertificateTests
    {
        [Fact]
        public void ResourceCertificate_ToImportRequest_Append_AllShouldMapParameters()
        {
            ResourceCertificate model = new()
            {
                ResourceNo = "RESOURCE1",
                LastScoreDate = new DateTime(2020, 1, 1),
                No = "NO",
                Score = "SCORE",
                ValidUntil = new DateTime(2020, 1, 2)
            };
        }
    }
}