namespace Dime.Scheduler.Sdk
{
    public class MessageRequest
    {
        public string Text { get; set; }

        public string User { get; set; }

        public Severity Severity { get; set; }
    }
}