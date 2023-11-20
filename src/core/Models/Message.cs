using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Sdk
{
    [ExcludeFromCodeCoverage]
    public record Message(string Text, string User, Severity Severity);
}