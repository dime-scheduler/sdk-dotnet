namespace Dime.Scheduler.Sdk
{
    public abstract class EndpointBuilder<T>
    {
        protected EndpointBuilder()
        {
        }

        protected abstract T Create(AuthenticationOptions opts);
    }
}