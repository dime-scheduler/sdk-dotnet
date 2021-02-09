namespace Dime.Scheduler.Sdk
{
    internal static class Routes
    {
        private static string _api = "api";

        internal static class Categories
        {
            private static string _endpoint = "Categories";

            internal static string Create = $"{_api}/{_endpoint}/Create";
            internal static string Update = $"{_api}/{_endpoint}/Update";
            internal static string Delete = $"{_api}/{_endpoint}/Delete";
        }

        internal static class Resources
        {
            private static string _endpoint = "Resources";

            internal static string Get = $"{_api}/{_endpoint}/Get";
        }

        internal static class Import
        {
            private static string _endpoint = "Import";

            internal static string Insert = $"{_api}/{_endpoint}/Insert";
            internal static string InsertData = $"{_api}/{_endpoint}/InsertData";
        }

        internal static class Messages
        {
            private static string _endpoint = "Messages";

            internal static string Post = $"{_api}/{_endpoint}/Create";
        }
    }
}