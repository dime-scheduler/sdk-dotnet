namespace Dime.Scheduler.Sdk
{
    internal static class StringExtensions
    {
        internal static string EnsureTrailingSlash(this string uri) => uri.EndsWith("/") ? uri : $"{uri}/";
    }
}