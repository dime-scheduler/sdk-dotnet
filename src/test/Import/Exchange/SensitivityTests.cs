using Dime.Scheduler.Entities.Exchange;
using Xunit;

namespace Dime.Scheduler.Tests.Models.Exchange
{
    public partial class SensitivityTests
    {
        [Fact]
        public void Sensitivity_Enum_ShouldMatchExchangeIntegerValues()
        {
            Assert.True((int)Sensitivity.Normal == 1);
            Assert.True((int)Sensitivity.Personal == 2);
            Assert.True((int)Sensitivity.Private == 3);
            Assert.True((int)Sensitivity.Confidential == 4);
        }
    }
}