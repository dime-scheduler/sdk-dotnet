using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class TaskLockedTests
    {
        [Fact]
        public void TaskLocked_ToImportRequest_Append_AllShouldMapParameters()
        {
            TaskLocked model = new();
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}