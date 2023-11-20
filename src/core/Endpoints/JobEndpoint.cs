using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.Sdk
{
    public class JobEndpoint : DefaultEndpoint<Job>, IJobEndpoint
    {
        public JobEndpoint(AuthenticationOptions opts)
            : base(Routes.Job.Entity, opts)
        {
        }
    }
}