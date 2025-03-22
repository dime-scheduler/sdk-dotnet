using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class FilterValueTests
    {
        [Fact]
        public void FilterValue_ToImportRequest_Append_AllShouldMapParameters()
        {
            FilterValue model = new()
            {
                Group = "GROUP",
                Value = "VALUE"
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void FilterValue_ToImportRequest_Delete_AllShouldMapParameters()
        {
            FilterValue model = new("Group", "Value");
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void FilterValue_ToImportRequest_InvalidTransactionType_ShouldThrowArgumentOutOfRangeException()
            => ToImportRequestTestUtils.TestToInvalidImportRequest<FilterValue>();
    }
}