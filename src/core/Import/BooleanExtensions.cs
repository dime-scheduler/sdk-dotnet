namespace Dime.Scheduler.Sdk.Import
{
    internal static class BooleanExtensions
    {
        internal static int ToBit(this bool booleanParam) => booleanParam ? 1 : 0;

    }
}