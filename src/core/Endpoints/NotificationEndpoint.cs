using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.Sdk
{
    public class NotificationEndpoint : DefaultEndpoint<Notification>, INotificationEndpoint
    {
        public NotificationEndpoint(AuthenticationOptions opts)
            : base(Routes.Notification, opts)
        {
        }
    }
}