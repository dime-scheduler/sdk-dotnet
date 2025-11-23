using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class ResourceGpsTracking : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [ImportParameter(nameof(ResourceNo))]
        [MaxLength(50)]
        [Required]
        public string ResourceNo { get; set; }

        /// <summary>
        /// Gets or sets the GPS tracking resource number.
        /// </summary>
        [ImportParameter(nameof(GpsTrackingResourceNo))]
        [MaxLength(50)]
        public string GpsTrackingResourceNo { get; set; }

        /// <summary>
        /// Gets or sets the latitude coordinate.
        /// </summary>
        [ImportParameter(nameof(Latitude))]
        [Required]
        public decimal Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude coordinate.
        /// </summary>
        [ImportParameter(nameof(Longitude))]
        [Required]
        public decimal Longitude { get; set; }

        /// <summary>
        /// Gets or sets the speed.
        /// </summary>
        [ImportParameter(nameof(Speed))]
        public int? Speed { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the GPS tracking record.
        /// </summary>
        [ImportParameter(nameof(Date))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets the row identifier.
        /// </summary>
        [ImportParameter(nameof(RowId))]
        [MaxLength(100)]
        public string RowId { get; set; }

        /// <summary>
        /// Gets or sets the power level.
        /// </summary>
        [ImportParameter(nameof(Power))]
        [MaxLength(50)]
        public string Power { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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