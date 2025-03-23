using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Entities
{
    [ExcludeFromCodeCoverage]
    public class Message
    {
        public string Text { get; set; }

        public string User { get; set; }

        public Severity Severity { get; set; }
    };
}