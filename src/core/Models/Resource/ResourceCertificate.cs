using System;

namespace Dime.Scheduler.Entities
{
    public class ResourceCertificate : IImportRequestable
    {
        [ImportParameter(nameof(ResourceNo), TransactionType.Append, TransactionType.Delete)]
        public string ResourceNo { get; set; }

        [ImportParameter("CertificateNo", TransactionType.Append, TransactionType.Delete)]
        public string No { get; set; }

        [ImportParameter(nameof(Score), TransactionType.Append)]
        public string Score { get; set; }

        [ImportParameter(nameof(LastScoreDate), TransactionType.Append)]
        public DateTime LastScoreDate { get; set; }

        [ImportParameter(nameof(ValidUntil), TransactionType.Append)]
        public DateTime ValidUntil { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
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