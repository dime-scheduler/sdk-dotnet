using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class ExchangeAppointmentTests
    {
        [Fact]
        public void ExchangeAppointment_ToImportRequest_Append_AllShouldMapParameters()
        {
            ExchangeAppointment model = new();
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}