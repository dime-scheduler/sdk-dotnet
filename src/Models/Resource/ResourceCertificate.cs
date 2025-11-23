using System;

namespace Dime.Scheduler.Entities
{
    public class ResourceCertificate : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [ImportParameter(nameof(ResourceNo), TransactionType.Append, TransactionType.Delete)]
        public string ResourceNo { get; set; }

        /// <summary>
        /// Gets or sets the certificate number.
        /// </summary>
        [ImportParameter("CertificateNo", TransactionType.Append, TransactionType.Delete)]
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the certificate score.
        /// </summary>
        [ImportParameter(nameof(Score), TransactionType.Append)]
        public string Score { get; set; }

        /// <summary>
        /// Gets or sets the last score date.
        /// </summary>
        [ImportParameter(nameof(LastScoreDate), TransactionType.Append)]
        public DateTime LastScoreDate { get; set; }

        /// <summary>
        /// Gets or sets the date until which the certificate is valid.
        /// </summary>
        [ImportParameter(nameof(ValidUntil), TransactionType.Append)]
        public DateTime ValidUntil { get; set; }

        ImportRequest IImportEntity.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.Resource.Certificate.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => new(ImportProcedures.Resource.Certificate.Delete, this.CreateParameters(TransactionType.Delete));
    }
}