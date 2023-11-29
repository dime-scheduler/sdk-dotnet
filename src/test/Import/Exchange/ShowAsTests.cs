using Dime.Scheduler.Entities.Exchange;
using Xunit;

namespace Dime.Scheduler.Tests.Models.Exchange
{
    public partial class ShowAsTests
    {
        [Fact]
        public void ShowAs_Enum_ShouldMatchExchangeIntegerValues()
        {
            Assert.True((int)ShowAs.Free == 1);
            Assert.True((int)ShowAs.Tentative == 2);
            Assert.True((int)ShowAs.Office == 3);
            Assert.True((int)ShowAs.OutOfOffice == 4);
            Assert.True((int)ShowAs.WorkingElsewhere == 5);
            Assert.True((int)ShowAs.Unknown == 6);
        }
    }
}