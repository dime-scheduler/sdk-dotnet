using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public class AppointmentUri : IAppointmentIdentifier, IImportRequestable
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter("pSourceApp")]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter("pSourceType")]
        [MaxLength(10)]
        public string SourceType { get; set; }

        public string AppointmentNo { get; set; }

        [ImportParameter("pAppointmentId")]
        public long AppointmentId { get; set; }

        [ImportParameter("pAppointmentGuid")]
        public Guid? AppointmentGuid { get; set; }

        [ImportParameter("pUrl")]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(1000)]
        public string Uri { get; set; }

        [ImportParameter("pUrlDesc")]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(255)]
        public string Description { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Appointment.Uri.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException("Action does not exist yet in Dime.Scheduler");
    }
}