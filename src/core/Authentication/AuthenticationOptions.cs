namespace Dime.Scheduler.Sdk
{
    public record AuthenticationOptions
    {
        public string Uri { get; set; }
        public string AuthenticationToken { get; set; }

        public AuthenticationOptions(string uri, string authenticationToken)
            => (Uri, AuthenticationToken) = (uri, authenticationToken);

        public void Deconstruct(out string uri, out string authenticationToken)
            => (uri, authenticationToken) = (Uri, AuthenticationToken);
    }
}