﻿using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
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

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void ResourceCertificate_ToImportRequest_Delete_AllShouldMapParameters()
        {
            ResourceCertificate model = new()
            {
                ResourceNo = "RESOURCE1",
                LastScoreDate = new DateTime(2020, 1, 1),
                No = "NO",
                Score = "SCORE",
                ValidUntil = new DateTime(2020, 1, 2)
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void ResourceCertificate_ToImportRequest_InvalidTransactionType_ShouldThrowArgumentOutOfRangeException()
            => ToImportRequestTestUtils.TestToInvalidImportRequest<ResourceCertificate>();
    }
}