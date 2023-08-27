namespace Dime.Scheduler.Sdk
{
    public class NotificationEndpoint : DefaultEndpoint<Import.Notification>, INotificationEndpoint
    {
        public NotificationEndpoint(AuthenticationOptions opts)
            : base(Routes.Notification, opts)
        {
        }
    }
}