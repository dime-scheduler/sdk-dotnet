namespace Dime.Scheduler.Sdk.Import
{
    internal static class ImportProcedures
    {
        private static string _base = "mboc_";
        private static string _append = "upsert";
        private static string _delete = "delete";

        private static string FilterValue = "FilterValue";
        private static string ActionUri = "ActionUrl";

        internal static string AppendActionUri = $"{_base}{_append}{ActionUri}";
        internal static string AppendFilterValue = $"{_base}{_append}{FilterValue}";
        internal static string DeleteFilterValue = $"{_base}{_delete}{FilterValue}";

    }
}