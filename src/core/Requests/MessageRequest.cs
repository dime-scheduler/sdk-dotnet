using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Sdk
{
    [ExcludeFromCodeCoverage]
    public class MessageRequest
    {
        public string Text { get; set; }

        public string User { get; set; }

        public Severity Severity { get; set; }
    }
}