namespace Dime.Scheduler.Sdk
{
    public class DimeSchedulerClient
    {
        public DimeSchedulerClient(AuthenticationOptions opts)
        {
            Import = new ImportEndpoint(opts);
            Messages = new MessagesEndpoint(opts);
            Users = new UsersEndpoint(opts);
            Resources = new ResourcesEndpoint(opts);
            Tasks = new TaskEndpoint(opts);
            Pins = new PinsEndpoint(opts);
            Categories = new CategoriesEndpoint(opts);
            TimeMarkers = new TimeMarkersEndpoint(opts);
            Appointments = new AppointmentEndpoint(opts);
        }

        public IImportEndpoint Import { get; }
        public IMessageEndpoint Messages { get; }
        public UsersEndpoint Users { get; }
        public IResourceEndpoint Resources { get; }
        public ITaskEndpoint Tasks { get; }
        public IPinEndpoint Pins { get; }
        public ICategoryEndpoint Categories { get; }
        public ITimeMarkerEndpoint TimeMarkers { get; }
        public IAppointmentEndpoint Appointments { get; }
    }
}