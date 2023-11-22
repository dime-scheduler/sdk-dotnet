using System;

namespace Dime.Scheduler.Sdk
{
    public class DimeSchedulerClient
    {
        public DimeSchedulerClient(Environment environment, string key)
            : this(new AuthenticationOptions(environment.ToUrl(), key))
        {
        }

        public DimeSchedulerClient(string key)
            : this(Environment.Production, key)
        {
        }

        public DimeSchedulerClient(string uri, string key)
            : this(new AuthenticationOptions(uri, key))
        {
        }

        private DimeSchedulerClient(AuthenticationOptions opts)
        {
            ActionUris = new ActionUriEndpoint(opts);
            Appointments = new AppointmentEndpoint(opts);
            Captions = new CaptionEndpoint(opts);
            Captions = new CaptionEndpoint(opts);
            Connectors = new ConnectorEndpoint(opts);
            Categories = new CategoriesEndpoint(opts);
            Containers = new ContainerEndpoint(opts);
            FilterGroups = new FilterGroupEndpoint(opts);
            FilterValues = new FilterValueEndpoint(opts);
            Import = new ImportEndpoint(opts);
            Jobs = new JobEndpoint(opts);
            Messages = new MessagesEndpoint(opts);
            Notifications = new NotificationEndpoint(opts);
            Pins = new PinsEndpoint(opts);
            Resources = new ResourcesEndpoint(opts);
            Tasks = new TaskEndpoint(opts);
            TimeMarkers = new TimeMarkersEndpoint(opts);
            Users = new UsersEndpoint(opts);
        }

        public IActionUriEndpoint ActionUris { get; }
        public IAppointmentEndpoint Appointments { get; }
        public ICaptionEndpoint Captions { get; }

        [Obsolete("This endpoint is in preview.")]
        public IConnectorEndpoint Connectors { get; }

        public ICategoryEndpoint Categories { get; }
        public IContainerEndpoint Containers { get; }
        public IFilterGroupEndpoint FilterGroups { get; }
        public IFilterValueEndpoint FilterValues { get; }
        public IImportEndpoint Import { get; }
        public IJobEndpoint Jobs { get; }
        public IMessageEndpoint Messages { get; }
        public INotificationEndpoint Notifications { get; }
        public IPinEndpoint Pins { get; }
        public IResourceEndpoint Resources { get; }
        public ITaskEndpoint Tasks { get; }
        public ITimeMarkerEndpoint TimeMarkers { get; }
        public IUserEndpoint Users { get; }
    }
}