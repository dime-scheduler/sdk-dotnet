using System.Diagnostics.CodeAnalysis;
using Dime.Scheduler.Entities;
using Dime.Scheduler.Internal;

namespace Dime.Scheduler
{
    /// <summary>
    /// The Dime.Scheduler client. Every entity lives behind a domain accessor
    /// (<c>client.Appointments</c>, <c>client.Resources</c>, ...) exposing CRUD methods.
    /// </summary>
    /// <example>
    /// <code>
    /// var client = new DimeSchedulerClient(apiKey);
    /// await client.Appointments.CreateAsync(new Appointment { ... });
    /// await client.Resources.UpdateAsync(new[] { resource1, resource2 });
    /// </code>
    /// </example>
    public sealed class DimeSchedulerClient
    {
        [ExcludeFromCodeCoverage]
        public DimeSchedulerClient(string key, Environment environment = Environment.Production)
            : this(new EndpointOptions(environment.ToUrl(), key))
        {
        }

        [ExcludeFromCodeCoverage]
        public DimeSchedulerClient(string key) : this(key, Environment.Production)
        {
        }

        internal DimeSchedulerClient(string key, string uri) : this(new EndpointOptions(uri, key))
        {
        }

        private DimeSchedulerClient(EndpointOptions opts)
        {
            Dispatcher d = new(opts);

            ActionUris = new CrudApi<ActionUri>(d, "/actionUri");
            Appointments = new AppointmentApi(d);
            AppointmentDependencies = new AppointmentDependencyApi(d);
            AppointmentFields = new AppointmentFieldApi(d);
            AppointmentCategories = new CrudApi<AppointmentCategory>(d, "/appointmentCategory");
            AppointmentContents = new CrudApi<AppointmentContent>(d, "/appointmentContent");
            AppointmentContainers = new CrudApi<AppointmentContainer>(d, "/appointmentContainer");
            AppointmentFieldValues = new CrudApi<AppointmentFieldValue>(d, "/appointmentFieldValue");
            AppointmentImportances = new CrudApi<AppointmentImportance>(d, "/appointmentImportance");
            AppointmentLocked = new CrudApi<AppointmentLocked>(d, "/appointmentLocked");
            AppointmentPlanningQuantities = new CrudApi<AppointmentPlanningQuantity>(d, "/appointmentPlanningQuantity");
            AppointmentTimeMarkers = new CrudApi<AppointmentTimeMarker>(d, "/appointmentTimeMarker");
            AppointmentUris = new CrudApi<AppointmentUri>(d, "/appointmentUri");
            Assignments = new CrudApi<Assignment>(d, "/assignment");
            Captions = new CrudApi<Caption>(d, "/caption");
            Categories = new CrudApi<Category>(d, "/category");
            Containers = new CrudApi<Container>(d, "/container");
            FilterGroups = new CrudApi<FilterGroup>(d, "/filterGroup");
            FilterValues = new CrudApi<FilterValue>(d, "/filterValue");
            Jobs = new CrudApi<Job>(d, "/job");
            Notifications = new NotificationApi(d);
            Pins = new CrudApi<Pin>(d, "/pin");
            Resources = new CrudApi<Resource>(d, "/resource");
            ResourceCalendars = new CrudApi<ResourceCalendar>(d, "/resourceCalendar");
            ResourceCapacities = new ResourceCapacityApi(d);
            ResourceTypes = new ResourceTypeApi(d);
            Calendars = new CalendarApi(d);
            ResourceCertificates = new CrudApi<ResourceCertificate>(d, "/resourceCertificate");
            ResourceFilterValues = new CrudApi<ResourceFilterValue>(d, "/resourceFilterValue");
            ResourceGpsTrackings = new CrudApi<ResourceGpsTracking>(d, "/resourceGpsTracking");
            ResourceUris = new CrudApi<ResourceUri>(d, "/resourceUri");
            Tasks = new CrudApi<Entities.Task>(d, "/task");
            TaskContainers = new CrudApi<TaskContainer>(d, "/taskContainer");
            TaskFilterValues = new CrudApi<TaskFilterValue>(d, "/taskFilterValue");
            TaskLocked = new CrudApi<TaskLocked>(d, "/taskLocked");
            TaskUris = new CrudApi<TaskUri>(d, "/taskUri");
            TimeMarkers = new CrudApi<TimeMarker>(d, "/timeMarker");

            Connectors = new ConnectorApi(d);
            Messages = new MessageApi(d);
            Geocoding = new GeocodeApi(d);
            Optimization = new OptimizationApi(d);
            Recommendation = new RecommendationApi(d);
            Users = new UserApi(d);
        }

        public CrudApi<ActionUri> ActionUris { get; }
        public AppointmentApi Appointments { get; }
        public AppointmentDependencyApi AppointmentDependencies { get; }
        public AppointmentFieldApi AppointmentFields { get; }
        public CrudApi<AppointmentCategory> AppointmentCategories { get; }
        public CrudApi<AppointmentContent> AppointmentContents { get; }
        public CrudApi<AppointmentContainer> AppointmentContainers { get; }
        public CrudApi<AppointmentFieldValue> AppointmentFieldValues { get; }
        public CrudApi<AppointmentImportance> AppointmentImportances { get; }
        public CrudApi<AppointmentLocked> AppointmentLocked { get; }
        public CrudApi<AppointmentPlanningQuantity> AppointmentPlanningQuantities { get; }
        public CrudApi<AppointmentTimeMarker> AppointmentTimeMarkers { get; }
        public CrudApi<AppointmentUri> AppointmentUris { get; }
        public CrudApi<Assignment> Assignments { get; }
        public CrudApi<Caption> Captions { get; }
        public CrudApi<Category> Categories { get; }
        public CrudApi<Container> Containers { get; }
        public CrudApi<FilterGroup> FilterGroups { get; }
        public CrudApi<FilterValue> FilterValues { get; }
        public CrudApi<Job> Jobs { get; }
        public NotificationApi Notifications { get; }
        public CrudApi<Pin> Pins { get; }
        public CrudApi<Resource> Resources { get; }
        public CrudApi<ResourceCalendar> ResourceCalendars { get; }
        public ResourceCapacityApi ResourceCapacities { get; }
        public ResourceTypeApi ResourceTypes { get; }
        public CalendarApi Calendars { get; }
        public CrudApi<ResourceCertificate> ResourceCertificates { get; }
        public CrudApi<ResourceFilterValue> ResourceFilterValues { get; }
        public CrudApi<ResourceGpsTracking> ResourceGpsTrackings { get; }
        public CrudApi<ResourceUri> ResourceUris { get; }
        public CrudApi<Entities.Task> Tasks { get; }
        public CrudApi<TaskContainer> TaskContainers { get; }
        public CrudApi<TaskFilterValue> TaskFilterValues { get; }
        public CrudApi<TaskLocked> TaskLocked { get; }
        public CrudApi<TaskUri> TaskUris { get; }
        public CrudApi<TimeMarker> TimeMarkers { get; }

        public ConnectorApi Connectors { get; }
        public MessageApi Messages { get; }
        public GeocodeApi Geocoding { get; }
        public OptimizationApi Optimization { get; }
        public RecommendationApi Recommendation { get; }
        public UserApi Users { get; }
    }
}
