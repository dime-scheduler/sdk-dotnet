namespace Dime.Scheduler.Sdk
{
    public record AuthenticationOptions
    {
        public string Uri { get; }
        public string Key { get; }

        public AuthenticationOptions(string uri, string key)
            => (Uri, Key) = (uri, key);

        public void Deconstruct(out string uri, out string key)
            => (uri, key) = (Uri, Key);
    }
}