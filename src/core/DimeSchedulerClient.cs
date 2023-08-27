namespace Dime.Scheduler.Sdk
{
    public class DimeSchedulerClient
    {
        public DimeSchedulerClient(AuthenticationOptions opts)
        {
            ActionUris = new ActionUriEndpoint(opts);
            Appointments = new AppointmentEndpoint(opts);
            Import = new ImportEndpoint(opts);
            Messages = new MessagesEndpoint(opts);
            Users = new UsersEndpoint(opts);
            Resources = new ResourcesEndpoint(opts);
            Tasks = new TaskEndpoint(opts);
            Pins = new PinsEndpoint(opts);
            Categories = new CategoriesEndpoint(opts);
            TimeMarkers = new TimeMarkersEndpoint(opts);
            Captions = new CaptionEndpoint(opts);
            Jobs = new JobEndpoint(opts);
            Captions = new CaptionEndpoint(opts);
            Containers = new ContainerEndpoint(opts);
            Notifications = new NotificationEndpoint(opts);
            FilterGroups = new FilterGroupEndpoint(opts);
            FilterValues = new FilterValueEndpoint(opts);
        }

        public IActionUriEndpoint ActionUris { get; set; }
        public IAppointmentEndpoint Appointments { get; set; }
        public ICaptionEndpoint Captions { get; set; }
        public ICategoryEndpoint Categories { get; set; }
        public IContainerEndpoint Containers { get; set; }
        public IFilterGroupEndpoint FilterGroups { get; set; }
        public IFilterValueEndpoint FilterValues { get; set; }
        public IJobEndpoint Jobs { get; set; }
        public INotificationEndpoint Notifications { get; set; }
        public IMessageEndpoint Messages { get; }
        public IUserEndpoint Users { get; }
        public IResourceEndpoint Resources { get; }
        public ITaskEndpoint Tasks { get; }
        public IPinEndpoint Pins { get; }
        public ITimeMarkerEndpoint TimeMarkers { get; }

        public IImportEndpoint Import { get; }
    }
}