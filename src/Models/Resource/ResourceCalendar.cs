using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class ResourceCalendar : IImportEntity
    {
        /// <summary>
        /// Gets or sets the resource calendar code.
        /// </summary>
        [ImportParameter("ResourceCalendarCode", TransactionType.Append, TransactionType.Delete)]
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [ImportParameter(nameof(ResourceNo), TransactionType.Append)]
        [Required]
        [MaxLength(50)]
        public string ResourceNo { get; set; }

        /// <summary>
        /// Gets or sets the calendar code.
        /// </summary>
        [ImportParameter(nameof(CalendarCode), TransactionType.Append)]
        [Required]
        [MaxLength(255)]
        public string CalendarCode { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        [ImportParameter(nameof(StartDate), TransactionType.Append)]
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        [ImportParameter(nameof(EndDate), TransactionType.Append)]
        [Required]
        public DateTime EndDate { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Resource.Calendar.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Resource.Calendar.Delete, this.CreateParameters(TransactionType.Delete));
    }
}