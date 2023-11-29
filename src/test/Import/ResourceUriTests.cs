using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class ResourceUriTests
    {
        [Fact]
        public void ResourceUri_ToImportRequest_Append_AllShouldMapParameters()
        {
            ResourceUri model = new()
            {
                Description = "TEXT",
                ResourceNo = "TEXT",
                Uri = "TEXT"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}