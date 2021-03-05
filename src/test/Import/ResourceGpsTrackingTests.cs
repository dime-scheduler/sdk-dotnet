using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class ResourceGpsTrackingTests
    {
        [Fact]
        public void ResourceGpsTracking_ToImportRequest_Append_AllShouldMapParameters()
        {
            ResourceGpsTracking model = new()
            {
                Date = new DateTime(2020, 1, 1),
                ResourceNo = "LINDA",
                GpsTrackingResourceNo = "NO",
                Latitude = 1,
                Longitude = 2,
                Power = "MAX",
                RowId = "1",
                Speed = 1
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void ResourceGpsTracking_ToImportRequest_Delete_AllShouldMapParameters()
        {
            ResourceGpsTracking model = new()
            {
                Date = new DateTime(2020, 1, 1),
                ResourceNo = "LINDA",
                GpsTrackingResourceNo = "NO",
                Latitude = 1,
                Longitude = 2,
                Power = "MAX",
                RowId = "1",
                Speed = 1
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}