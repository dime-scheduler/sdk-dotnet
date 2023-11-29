namespace Dime.Scheduler
{
    public record EndpointOptions
    {
        public string Uri { get; }
        public string Key { get; }

        public EndpointOptions(Environment environment, string key)
            => (Uri, Key) = (environment.ToUrl(), key);

        public EndpointOptions(string key) : this(Environment.Production, key)
        {
        }

        public EndpointOptions(string uri, string key)
            => (Uri, Key) = (uri, key);

        public void Deconstruct(out string uri, out string key)
            => (uri, key) = (Uri, Key);
    }
}