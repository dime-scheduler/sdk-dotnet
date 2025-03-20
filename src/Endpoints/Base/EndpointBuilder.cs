namespace Dime.Scheduler
{
    public abstract class EndpointBuilder<T>
    {
        protected EndpointBuilder()
        {
        }

        protected abstract T Create(EndpointOptions opts);
    }
}