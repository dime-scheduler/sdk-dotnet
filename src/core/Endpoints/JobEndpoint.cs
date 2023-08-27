namespace Dime.Scheduler.Sdk
{
    public class JobEndpoint : DefaultEndpoint<Import.Job>, IJobEndpoint
    {
        public JobEndpoint(AuthenticationOptions opts)
            : base(Routes.Job.Entity, opts)
        {
        }
    }
}