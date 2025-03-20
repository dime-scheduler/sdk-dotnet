using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class ResourceGpsTracking : IImportRequestable
    {
        [ImportParameter(nameof(ResourceNo))]
        [MaxLength(50)]
        [Required]
        public string ResourceNo { get; set; }

        [ImportParameter(nameof(GpsTrackingResourceNo))]
        [MaxLength(50)]
        public string GpsTrackingResourceNo { get; set; }

        [ImportParameter(nameof(Latitude))]
        [Required]
        public decimal Latitude { get; set; }

        [ImportParameter(nameof(Longitude))]
        [Required]
        public decimal Longitude { get; set; }

        [ImportParameter(nameof(Speed))]
        public int? Speed { get; set; }

        [ImportParameter(nameof(Date))]
        public DateTime? Date { get; set; }

        [ImportParameter(nameof(RowId))]
        [MaxLength(100)]
        public string RowId { get; set; }

        [ImportParameter(nameof(Power))]
        [MaxLength(50)]
        public string Power { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Resource.GpsTracking.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Resource.GpsTracking.Delete, this.CreateParameters(TransactionType.Delete));
    }
}