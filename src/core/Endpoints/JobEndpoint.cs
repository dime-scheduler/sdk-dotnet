using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    internal class JobEndpoint : DefaultEndpoint<Job>, IJobEndpoint
    {
        internal JobEndpoint(EndpointOptions opts) : base(Routes.Job.Entity, opts)
        {
        }
    }
}