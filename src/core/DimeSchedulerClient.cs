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

        public IActionUriEndpoint ActionUris { get; set; }
        public IAppointmentEndpoint Appointments { get; set; }
        public ICaptionEndpoint Captions { get; set; }
        public ICategoryEndpoint Categories { get; set; }
        public IContainerEndpoint Containers { get; set; }
        public IFilterGroupEndpoint FilterGroups { get; set; }
        public IFilterValueEndpoint FilterValues { get; set; }
        public IImportEndpoint Import { get; }
        public IJobEndpoint Jobs { get; set; }
        public IMessageEndpoint Messages { get; }
        public INotificationEndpoint Notifications { get; set; }
        public IPinEndpoint Pins { get; }
        public IResourceEndpoint Resources { get; }
        public ITaskEndpoint Tasks { get; }
        public ITimeMarkerEndpoint TimeMarkers { get; }
        public IUserEndpoint Users { get; }
    }
}