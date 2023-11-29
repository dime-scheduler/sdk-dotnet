using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public class JobEndpoint : DefaultEndpoint<Job>, IJobEndpoint
    {
        public JobEndpoint(EndpointOptions opts)
            : base(Routes.Job.Entity, opts)
        {
        }
    }
}