namespace Dime.Scheduler.Sdk
{
    public abstract class BaseRequest : IRequestParameter
    {
        public string Uri { get; set; }
        public string AuthenticationToken { get; set; }
    }
}