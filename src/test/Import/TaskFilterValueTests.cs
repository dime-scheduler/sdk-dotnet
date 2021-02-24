using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class TaskFilterValueTests
    {
        [Fact]
        public void TaskFilterValue_ToImportRequest_Append_AllShouldMapParameters()
        {
            TaskFilterValue model = new();
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}