using System;

namespace Dime.Scheduler.Sdk.Import
{
    public class ActionUri : IImportRequestable
    {
        [ImportParameter(nameof(SourceApp))]
        public string SourceApp { get; set; }

        [ImportParameter(nameof(SourceType))]
        public string SourceType { get; set; }

        [ImportParameter(nameof(UriType))]
        public int UriType { get; set; }

        [ImportParameter(nameof(Uri))]
        public string Uri { get; set; }

        [ImportParameter(nameof(Description))]
        public string Description { get; set; }

        [ImportParameter(nameof(Default))]
        public bool Default { get; set; }

        ImportRequest IImportRequestable.ToImportRequest(TransactionType transactionType)
            => transactionType switch
            {
                TransactionType.Append => CreateAppendRequest(),
                TransactionType.Delete => CreateDeleteRequest(),
                _ => throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null)
            };

        private ImportRequest CreateAppendRequest()
            => new(ImportProcedures.ActionUri.Append, this.CreateParameters(TransactionType.Append));

        private ImportRequest CreateDeleteRequest()
            => throw new NotImplementedException("Action does not exist yet in Dime.Scheduler");
    }
}