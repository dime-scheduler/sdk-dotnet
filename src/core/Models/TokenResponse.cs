using System;
using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Sdk
{
    [ExcludeFromCodeCoverage]
    public class TokenResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public DateTime expires { get; set; }

    }
}