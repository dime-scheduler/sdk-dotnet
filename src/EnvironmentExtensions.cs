namespace Dime.Scheduler
{
    internal static class EnvironmentExtensions
    {
        internal static string ToUrl(this Environment env)
            => env switch
            {
                Environment.Production => "https://api.dimescheduler.com",
                Environment.Sandbox => "https://api.sandbox.dimescheduler.com",
                _ => "https://api.dimescheduler.com"
            };
    }
}
