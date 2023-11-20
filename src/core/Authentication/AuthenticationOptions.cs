namespace Dime.Scheduler.Sdk
{
    public record AuthenticationOptions
    {
        public string Uri { get; }
        public string Key { get; }

        public AuthenticationOptions(Environment environment, string key)
            => (Uri, Key) = (environment.ToUrl(), key);

        public AuthenticationOptions(string key) : this(Environment.Production, key)
        {
        }

        public AuthenticationOptions(string uri, string key)
            => (Uri, Key) = (uri, key);

        public void Deconstruct(out string uri, out string key)
            => (uri, key) = (Uri, Key);
    }
}