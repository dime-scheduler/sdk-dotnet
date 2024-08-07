﻿using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Entities
{
    [ExcludeFromCodeCoverage]
    internal static class ImportProcedures
    {
        private static readonly string _base = "mboc_";

        private static readonly string _append = "upsert";
        private static readonly string _update = "update";
        private static readonly string _delete = "delete";

        internal static class ExchangeAppointment
        {
            private static readonly string _entity = "ExchangeAppointment";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class Appointment
        {
            private static readonly string _entity = "Appointment";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";

            internal static class Importance
            {
                private static readonly string _entity = "AppointmentImportance";

                internal static readonly string Append = $"{_base}{_update}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }

            internal static class Locked
            {
                private static readonly string _entity = "AppointmentLocked";

                internal static readonly string Append = $"{_base}{_update}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }

            internal static class PlanningQuantity
            {
                private static readonly string _entity = "AppointmentPlanningQty";

                internal static readonly string Append = $"{_base}{_update}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }

            internal static class Category
            {
                private static readonly string _entity = "AppointmentCategory";

                internal static readonly string Append = $"{_base}{_update}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }

            internal static class TimeMarker
            {
                private static readonly string _entity = "AppointmentTimeMarker";

                internal static readonly string Append = $"{_base}{_update}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }

            internal static class Content
            {
                private static readonly string _entity = "AppointmentContent";
                internal static readonly string Append = $"{_base}{_update}{_entity}";
            }

            internal static class Uri
            {
                private static readonly string _entity = "AppointmentUrl";

                internal static readonly string Append = $"{_base}{_append}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }

            internal static class FieldValue
            {
                private static readonly string _entity = "AppointmentFieldValues";

                internal static readonly string Append = $"{_base}{_update}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }
        }

        internal static class Assignment
        {
            private static readonly string _entity = "AppointmentResource";

            internal static readonly string Append = $"{_base}add{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class Connector
        {
            private static readonly string _entity = "Connector";

            internal static readonly string Append = $"{_base}add{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class Task
        {
            private static readonly string _entity = "Task";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";

            internal static class FilterValue
            {
                private static readonly string _entity = "TaskFilterValue";

                internal static readonly string Append = $"{_base}{_append}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";

                internal static readonly string Clear = $"{_base}Clear{_entity}";
            }

            internal static class Uri
            {
                private static readonly string _entity = "TaskUrl";

                internal static readonly string Append = $"{_base}{_append}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }
        }

        internal static class ActionUri
        {
            private static readonly string _entity = "ActionUrl";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
        }

        internal static class FilterValue
        {
            private static readonly string _entity = "FilterValue";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class FilterGroup
        {
            private static readonly string _entity = "FilterGroup";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class TaskLocked
        {
            private static readonly string _entity = "TaskLocked";

            internal static readonly string Append = $"{_base}{_update}{_entity}";
        }

        internal static class TaskContainer
        {
            private static readonly string _entity = "TaskContainer";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class Category
        {
            private static readonly string _entity = "Category";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class TimeMarker
        {
            private static readonly string _entity = "TimeMarker";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class Pin
        {
            private static readonly string _entity = "Pin";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class Notification
        {
            private static readonly string _entity = "Notification";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class Job
        {
            private static readonly string _entity = "Job";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class Resource
        {
            private static readonly string _entity = "Resource";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";

            internal static class FilterValue
            {
                private static readonly string _entity = "ResourceFilterValue";

                internal static readonly string Append = $"{_base}{_append}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";

                internal static readonly string Clear = $"{_base}Clear{_entity}";
            }

            internal static class Uri
            {
                private static readonly string _entity = "ResourceUrl";
                internal static readonly string Append = $"{_base}{_append}{_entity}";
            }

            internal static class GpsTracking
            {
                private static readonly string _entity = "ResourceGpsTracking";

                internal static readonly string Append = $"{_base}{_append}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }

            internal static class Certificate
            {
                private static readonly string _entity = "ResourceCertificate";

                internal static readonly string Append = $"{_base}{_append}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }

            internal static class Capacity
            {
                private static readonly string _entity = "ResourceCapacity";

                internal static readonly string Append = $"{_base}{_append}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }

            internal static class Calendar
            {
                private static readonly string _entity = "ResourceCalendar";

                internal static readonly string Append = $"{_base}{_append}{_entity}";
                internal static readonly string Delete = $"{_base}{_delete}{_entity}";
            }
        }

        internal static class Caption
        {
            private static readonly string _entity = "Caption";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class Container
        {
            private static readonly string _entity = "Container";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }

        internal static class AppointmentContainer
        {
            private static readonly string _entity = "AppointmentContainer";

            internal static readonly string Append = $"{_base}{_append}{_entity}";
            internal static readonly string Delete = $"{_base}{_delete}{_entity}";
        }
    }
}