using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public class NotificationEndpoint : DefaultEndpoint<Notification>, INotificationEndpoint
    {
        public NotificationEndpoint(EndpointOptions opts)
            : base(Routes.Notification, opts)
        {
        }
    }
}