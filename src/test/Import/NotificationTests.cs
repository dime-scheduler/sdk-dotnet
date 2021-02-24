using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class NotificationTests
    {
        [Fact]
        public void Notification_ToImportRequest_Append_AllShouldMapParameters()
        {
            Notification model = new();
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}