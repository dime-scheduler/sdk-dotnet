using System;
using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    public class ResourceCertificate : IImportEntity
    {
        /// <include file='docs.xml' path='docs/members[@name="Common"]/ResourceNo/*'/>
        [Description("The resource number.")]
        [ImportParameter(nameof(ResourceNo), TransactionType.Append, TransactionType.Delete)]
        public string ResourceNo { get; set; }

        /// <summary>
        /// the certificate number.
        /// </summary>
        [Description("The certificate number.")]
        [ImportParameter("CertificateNo", TransactionType.Append, TransactionType.Delete)]
        public string No { get; set; }

        /// <summary>
        /// the certificate score.
        /// </summary>
        [Description("The certificate score.")]
        [ImportParameter(nameof(Score), TransactionType.Append)]
        public string Score { get; set; }

        /// <summary>
        /// the last score date.
        /// </summary>
        [Description("The last score date.")]
        [ImportParameter(nameof(LastScoreDate), TransactionType.Append)]
        public DateTime LastScoreDate { get; set; }

        /// <summary>
        /// the date until which the certificate is valid.
        /// </summary>
        [Description("The date until which the certificate is valid.")]
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