using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Entities
{
    [ExcludeFromCodeCoverage]
    public record Message(string Text, string User, Severity Severity);
}