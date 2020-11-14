namespace Dime.Scheduler.Sdk
{
    public interface IRequestParameter
    {
        string Uri { get; set; }
        string AuthenticationToken { get; set; }
    }
}