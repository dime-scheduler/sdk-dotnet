using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Sdk
{
    [ExcludeFromCodeCoverage]
    public class Resource
    {
        public string Email { get; set; }

        public bool ExchangeIntegrationEnabled { get; set; }
    }
}