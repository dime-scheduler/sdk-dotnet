using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Sdk
{
    [ExcludeFromCodeCoverage]
    internal static class Routes
    {
        private static readonly string _api = "api";

        internal const string ActionUri = "actionuri";
        internal const string Caption = "caption";
        internal const string Container = "container";
        internal const string Category = "categories";
        internal const string TimeMarker = "timeMarker";
        internal const string Pin = "pin";
        internal const string Message = "message";
        internal const string Notification = "notification";

        internal static class Import
        {
            private static readonly string _endpoint = "import";

            internal static readonly string Insert = $"{_endpoint}";
            internal static readonly string InsertData = $"{_endpoint}";
        }

        internal static class Filter
        {
            internal const string Group = "filterGroup";
            internal const string Value = "filterValue";
        }

        internal static class Appointment
        {
            internal const string Entity = "appointment";
            internal const string Assignment = "assignment";
            internal const string Category = "appointmentCategory";
            internal const string Container = "appointmentContainer";
            internal const string AppointementContent = "appointmentContent";
            internal const string Importance = "appointmentImportance";
            internal const string Locked = "appointmentLocked";
            internal const string PlanningQuantity = "appointmentPlanningQuantity";
            internal const string TimeMarker = "appointmentTimeMarker";
            internal const string Uri = "appointmentUri";
            internal const string Content = "appointmentcontent";
        }

        internal static class Resource
        {
            internal const string Entity = "resource";
            internal const string Calendar = "resourceCalendar";
            internal const string Capacity = "resourceCapacity";
            internal const string Certificate = "resourceCertificate";
            internal const string FilterValue = "resourceFilterValue";
            internal const string GpsTracking = "resourceGpsTracking";
            internal const string Uri = "resourceUri";
        }

        internal static class Task
        {
            internal const string Entity = "task";
            internal const string Locked = "taskLocked";
            internal const string Uri = "taskUri";
            internal const string TimeMarker = "taskTimeMarker";
            internal const string Category = "taskCategory";
            internal const string Container = "/taskContainer";
            internal const string FilterValue = "/taskFilterValue";
        }

        internal static class Job
        {
            internal const string Entity = "job";
        }

        internal static class Users
        {
            private static readonly string _endpoint = "Administration/Users";

            internal static readonly string Create = $"{_api}/{_endpoint}/Create";
            internal static readonly string Update = $"{_api}/{_endpoint}/Update";
            internal static readonly string Delete = $"{_api}/{_endpoint}/Delete";
        }
    }
}