using System;
using System.Collections.Generic;

namespace Dime.Scheduler.Sdk.Import
{
    public class ResourceCertificate : IImportRequestable
    {
        public string ResourceNo { get; set; }

        public string No { get; set; }

        public string Score { get; set; }

        public DateTime LastScoreDate { get; set; }

        public DateTime ValidUntil { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType == TransactionType.Append
                ? CreateAppendRequest()
                : CreateDeleteRequest();

        private ImportRequest CreateAppendRequest()
            => new ImportRequest(
                "mboc_upsertResourceCertificate",
                new List<string> { "ResourceNo", "CertificateNo", "Score", "LastScoreDate", "ValidUntil" }.ToArray(),
                new List<string> { ResourceNo, No, Score, LastScoreDate.ToString("s"), LastScoreDate.ToString("s"), ValidUntil.ToString("s") }.ToArray());

        private ImportRequest CreateDeleteRequest()
            => new ImportRequest(
                "mboc_deleteResourceCertificate",
                new List<string> { "ResourceNo", "CertificateNo" }.ToArray(),
                new List<string> { ResourceNo, No }.ToArray());
    }
}