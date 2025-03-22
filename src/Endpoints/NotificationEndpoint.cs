using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    internal class NotificationEndpoint : DefaultEndpoint<Notification>, INotificationEndpoint
    {
        internal NotificationEndpoint(EndpointOptions opts) : base(Routes.Notification, opts)
        {
        }
    }
}