namespace Dime.Scheduler
{
    /// <summary>
    /// The starting point to interact with Dime.Scheduler.
    /// </summary>
    public class DimeSchedulerClient
    {
        /// <summary>
        /// Initializes the client
        /// </summary>
        /// <param name="key">The API key</param>
        /// <param name="environment">The environment. Defaults to Production.</param>
        public DimeSchedulerClient(string key, Environment environment = Environment.Production)
            : this(new EndpointOptions(environment.ToUrl(), key))
        {
        }

        /// <summary>
        /// Initializes the client
        /// </summary>
        /// <param name="key">The API key</param>
        public DimeSchedulerClient(string key)
            : this(key, Environment.Production)
        {
        }

        /// <summary>
        /// Initializes the client
        /// </summary>
        /// <param name="key">The API key</param>
        /// <param name="uri">The URI to the Dime.Scheduler API. </param>
        public DimeSchedulerClient(string key, string uri)
            : this(new EndpointOptions(uri, key))
        {
        }

        private DimeSchedulerClient(EndpointOptions opts)
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

        /// <summary>
        /// Actionable URIs that can be executed in the context of tasks and appointments.
        /// </summary>
        public IActionUriEndpoint ActionUris { get; }

        /// <summary>
        /// The events that are placed on the planning board.
        /// </summary>
        public IAppointmentEndpoint Appointments { get; }

        /// <summary>
        /// Localize the application with your own nomenclature.
        /// </summary>
        public ICaptionEndpoint Captions { get; }

        /// <summary>
        /// Connector info so Dime.Scheduler knows where to send appointment information to.
        /// ⚠️ This endpoint is currently in preview.
        /// </summary>
        public IConnectorEndpoint Connectors { get; }

        /// <summary>
        /// The visual indicator that renders the background color of appointments.
        /// </summary>
        public ICategoryEndpoint Categories { get; }

        /// <summary>
        /// Group tasks and appointments with containers.
        /// </summary>
        public IContainerEndpoint Containers { get; }

        /// <summary>
        /// Decorate resources (attributes) and tasks (requirements) with filter groups.
        /// </summary>
        public IFilterGroupEndpoint FilterGroups { get; }

        /// <summary>
        /// Decorate resources (attributes) and tasks (requirements) with filter groups and values.
        /// </summary>
        public IFilterValueEndpoint FilterValues { get; }

        /// <summary>
        /// The classic entry point to transfer data to Dime.Scheduler.
        /// </summary>
        public IImportEndpoint Import { get; }

        /// <summary>
        /// The high-level entity that represents the project or order that needs to be scheduled.
        /// </summary>
        public IJobEndpoint Jobs { get; }

        /// <summary>
        /// Transient messages to be displayed to the users.
        /// </summary>
        public IMessageEndpoint Messages { get; }

        /// <summary>
        /// Add additional information to jobs, tasks, or appointments.
        /// </summary>
        public INotificationEndpoint Notifications { get; }

        /// <summary>
        /// The visual indicator that renders the color of markers on the geographical map.
        /// </summary>
        public IPinEndpoint Pins { get; }

        /// <summary>
        /// The entities that you would like to plan.
        /// </summary>
        public IResourceEndpoint Resources { get; }

        /// <summary>
        /// The units of work that need to be executed by the resources.
        /// </summary>
        public ITaskEndpoint Tasks { get; }

        /// <summary>
        /// The visual indicator that renders the horizontal bar at the bottom of appointments.
        /// </summary>
        public ITimeMarkerEndpoint TimeMarkers { get; }

        /// <summary>
        /// The application users that can use Dime.Scheduler.
        /// </summary>
        public IUserEndpoint Users { get; }
    }
}