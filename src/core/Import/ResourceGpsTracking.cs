using System;
using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceGpsTracking : IImportRequestable
    {
        public string ResourceNo { get; set; }

        public string GpsTrackingResourceNo { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public int? Speed { get; set; }

        public DateTime? Date { get; set; }

        public string RowId { get; set; }

        public string Power { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertResourceGpsTracking",
                new List<string> { "ResourceNo", "GpsTrackingResourceNo", "Latitude", "Longitude", "Speed", "Date", "RowId", "Power" }.ToArray(),
                new List<string> { ResourceNo, GpsTrackingResourceNo, Latitude.ToString(), Longitude.ToString(), Speed?.ToString(), Date?.ToString("s"), RowId, Power }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException("Action does not exist yet in Dime.Scheduler");
    }
}