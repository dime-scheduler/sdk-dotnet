using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class ResourceCalendar : IImportEntity
    {
        /// <summary>
        /// the resource calendar code.
        /// </summary>
        [Description("The resource calendar code.")]
        [ImportParameter("ResourceCalendarCode", TransactionType.Append, TransactionType.Delete)]
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [Description("The resource number.")]
        [ImportParameter(nameof(ResourceNo), TransactionType.Append)]
        [Required]
        [MaxLength(50)]
        public string ResourceNo { get; set; }

        /// <summary>
        /// the calendar code.
        /// </summary>
        [Description("The calendar code.")]
        [ImportParameter(nameof(CalendarCode), TransactionType.Append)]
        [Required]
        [MaxLength(255)]
        public string CalendarCode { get; set; }

        /// <summary>
        /// the start date.
        /// </summary>
        [Description("The start date.")]
        [ImportParameter(nameof(StartDate), TransactionType.Append)]
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// the end date.
        /// </summary>
        [Description("The end date.")]
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