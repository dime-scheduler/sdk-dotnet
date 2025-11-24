using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class ResourceGpsTracking : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [Description("The resource number.")]
        [ImportParameter(nameof(ResourceNo))]
        [MaxLength(50)]
        [Required]
        public string ResourceNo { get; set; }

        /// <summary>
        /// the GPS tracking resource number.
        /// </summary>
        [Description("The GPS tracking resource number.")]
        [ImportParameter(nameof(GpsTrackingResourceNo))]
        [MaxLength(50)]
        public string GpsTrackingResourceNo { get; set; }

        /// <summary>
        /// the latitude coordinate.
        /// </summary>
        [Description("The latitude coordinate.")]
        [ImportParameter(nameof(Latitude))]
        [Required]
        public decimal Latitude { get; set; }

        /// <summary>
        /// the longitude coordinate.
        /// </summary>
        [Description("The longitude coordinate.")]
        [ImportParameter(nameof(Longitude))]
        [Required]
        public decimal Longitude { get; set; }

        /// <summary>
        /// the speed.
        /// </summary>
        [Description("The speed.")]
        [ImportParameter(nameof(Speed))]
        public int? Speed { get; set; }

        /// <summary>
        /// the date and time of the GPS tracking record.
        /// </summary>
        [Description("The date and time of the GPS tracking record.")]
        [ImportParameter(nameof(Date))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// the row identifier.
        /// </summary>
        [Description("The row identifier.")]
        [ImportParameter(nameof(RowId))]
        [MaxLength(100)]
        public string RowId { get; set; }

        /// <summary>
        /// the power level.
        /// </summary>
        [Description("The power level.")]
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