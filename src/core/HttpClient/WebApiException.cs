namespace Dime.Scheduler.Sdk
{
    public class WebApiException
    {
        public WebApiException()
        {
        }

        public string Error { get; set; }

        public string Description { get; set; }
    }
}