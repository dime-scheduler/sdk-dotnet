using System;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities
{
    public class AppointmentUri : IAppointmentIdentifier, IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceApp/*'/>
        [ImportParameter("pSourceApp")]
        [MaxLength(30)]
        public string SourceApp { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="TrackedEntity"]/SourceType/*'/>
        [ImportParameter("pSourceType")]
        [MaxLength(10)]
        public string SourceType { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentNo/*'/>
        public string AppointmentNo { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentId/*'/>
        [ImportParameter("pAppointmentId")]
        public long AppointmentId { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Appointment"]/AppointmentGuid/*'/>
        [ImportParameter("pAppointmentGuid")]
        public Guid? AppointmentGuid { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/Uri/*'/>
        [ImportParameter("pUrl")]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(1000)]
        public string Uri { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="Common"]/UriDescription/*'/>
        [ImportParameter("pUrlDesc")]
        [RequiredIf(TransactionType.Append)]
        [MaxLength(255)]
        public string Description { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
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