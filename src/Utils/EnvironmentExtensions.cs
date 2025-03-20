using System;

namespace Dime.Scheduler
{
    internal static class EnvironmentExtensions
    {
        internal static string ToUrl(this Environment enumerationValue)
            => enumerationValue switch
            {
                Environment.Production => "https://api.dimescheduler.com",
                Environment.Sandbox => "https://sandbox.api.dimescheduler.com",
                _ => throw new NotImplementedException()
            };
    }
}