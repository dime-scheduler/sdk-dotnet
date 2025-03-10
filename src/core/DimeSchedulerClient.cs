namespace Dime.Scheduler
{
    public class DimeSchedulerClient
    {
        /// <summary>
        /// Entry point to Dime.Scheduler.
        /// </summary>
        /// <param name="key">The API key to authenticate with.</param>
        /// <param name="environment">Choose between live and sandbox environment.</param>
        public DimeSchedulerClient(string key, Environment environment = Environment.Production)
            : this(new EndpointOptions(environment.ToUrl(), key))
        {
        }

        /// <summary>
        /// Entry point to Dime.Scheduler.
        /// </summary>
        /// <param name="key">The API key to authenticate with.</param>
        public DimeSchedulerClient(string key)
            : this(key, Environment.Production)
        {
        }

        /// <summary>
        /// Entry point to Dime.Scheduler.
        /// </summary>
        /// <param name="key">The API key to authenticate with.</param>
        /// <param name="uri">Connect to instances of Dime.Scheduler cloud other than the production and sandbox environments.</param>
        public DimeSchedulerClient(string key, string uri) : this(new EndpointOptions(uri, key))
        {
        }

        private DimeSchedulerClient(EndpointOptions opts)
        {
            ActionUris = new ActionUriEndpoint(opts);
            Appointments = new AppointmentEndpoint(opts);
            Captions = new CaptionEndpoint(opts);
            Captions = new CaptionEndpoint(opts);
            Connectors = new ConnectorEndpoint(opts);
            Containers = new ContainerEndpoint(opts);
            Filters = new FilterEndpoint(opts);
            Import = new ImportEndpoint(opts);
            Jobs = new JobEndpoint(opts);
            Messages = new MessagesEndpoint(opts);
            Notifications = new NotificationEndpoint(opts);
            Resources = new ResourcesEndpoint(opts);
            Tasks = new TaskEndpoint(opts);
            Indicators = new IndicatorEndpoint(opts);
            Users = new UsersEndpoint(opts);
        }

        public IActionUriEndpoint ActionUris { get; }

        public IAppointmentEndpoint Appointments { get; }

        public ICaptionEndpoint Captions { get; }

        public IConnectorEndpoint Connectors { get; }

        public IContainerEndpoint Containers { get; }

        public FilterEndpoint Filters { get; }

        public IImportEndpoint Import { get; }

        public IJobEndpoint Jobs { get; }

        public IMessageEndpoint Messages { get; }

        public INotificationEndpoint Notifications { get; }

        public IndicatorEndpoint Indicators { get; }

        public IResourceEndpoint Resources { get; }

        public ITaskEndpoint Tasks { get; }

        public IUserEndpoint Users { get; }
    }
}