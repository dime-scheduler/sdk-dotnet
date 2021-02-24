using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class ResourceGpsTrackingTests
    {
        [Fact]
        public void ResourceGpsTracking_ToImportRequest_Append_AllShouldMapParameters()
        {
            ResourceGpsTracking model = new();
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}