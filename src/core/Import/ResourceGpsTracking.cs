using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceGpsTracking : IImportRequestable
    {
        [ImportParameter(nameof(ResourceNo))]
        public string ResourceNo { get; set; }

        [ImportParameter(nameof(GpsTrackingResourceNo))]
        public string GpsTrackingResourceNo { get; set; }

        [ImportParameter(nameof(Latitude))]
        public decimal Latitude { get; set; }

        [ImportParameter(nameof(Longitude))]
        public decimal Longitude { get; set; }

        [ImportParameter(nameof(Speed))]
        public int? Speed { get; set; }

        [ImportParameter(nameof(Date))]
        public DateTime? Date { get; set; }

        [ImportParameter(nameof(RowId))]
        public string RowId { get; set; }

        [ImportParameter(nameof(Power))]
        public string Power { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(ImportProcedures.Resource.GpsTracking.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(ImportProcedures.Resource.GpsTracking.Delete, this.CreateParameters(TransactionType.Delete));
    }
}